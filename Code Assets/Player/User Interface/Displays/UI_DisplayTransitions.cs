using UnityEngine;

public class UI_DisplayTransitions {
    private GameObject _MainDisplay;
    private ISwapperMediator _InputSwapper;
    private IGetReceiverFunctionality _InputReceivers;
    private IDisplayUI _ActiveDisplay;

    public UI_DisplayTransitions(GameObject display, ISwapperMediator inputSwapper, IGetReceiverFunctionality inputReceivers) {
        _MainDisplay = display;
        _InputSwapper = inputSwapper;
        _InputReceivers = inputReceivers;
        ResetInputReceiverReferences(); //On first load, setup the input receivers to not interact with the UI
        ShowDefaultDisplay();
    }

    private void ShowDefaultDisplay() {
        /*
         *@Desc: Hud is the default window that will be displayed to the user once the player gameobject has fully loaded into the scene
        */
        GameObject hudDisplay = _MainDisplay.transform.Find("Hud").gameObject;
        _ActiveDisplay = new UI_Hud(hudDisplay, _InputSwapper, _InputReceivers, this);
        _ActiveDisplay.ShowDisplay();
    }

    private void ResetInputReceiverReferences() {
        /*
         *@Desc: Reset the input receivers to ignore UI elements after every display transition ensuring no lingering behavior between transitions 
        */
        IReceiverDirectTransitionHandler directTransitions = _InputReceivers.GetDirectTransitionReceiver;
        directTransitions.SetBackTransitionStrategy = new Strategy_TransitionToPreviousDisplayIgnore();
        directTransitions.SetGameMenuTransitionStrategy = new Strategy_GameMenuTransitionIgnore();
        directTransitions.SetPlayerMenuTransitionStrategy = new Strategy_PlayerMenuTransitionIgnore();

        IReceiverHandleElementNavigation elementNavigation = _InputReceivers.GetUIElementNavigationReceiver;
        elementNavigation.SetUIElementNavigationStrategy = new Strategy_NavigateElementIgnore();

        IReceiverHandleElementSubmission elementSubmission = _InputReceivers.GetUIElementSubmissionReceiver;
        elementSubmission.SetUIElementSubmissionTypeOneStrategy = new Strategy_ElementSubmissionTypeOneIgnore();
        elementSubmission.SetUIElementSubmissionTypeTwoStrategy = new Strategy_ElementSubmissionTypeTwoIgnore();
        elementSubmission.SetUIElementSubmissionTypeThreeStrategy = new Strategy_ElementSubmissionTypeThreeIgnore();
        elementSubmission.SetUIElementSubmissionTypeFourStrategy = new Strategy_ElementSubmissionTypeFourIgnore();

        IReceiverHandlerSubWindowNavigation subWindowNavigation = _InputReceivers.GetSubWindowNavigation;
        subWindowNavigation.SetUISubWindowNavigationStrategy = new Strategy_NavigateSubWindowIgnore();
    }

    public void TransitionToHud() {
        /*
        *@Desc: Will create display the player's Hud, but first will disable the old UI display and reset the input receivers references
        */
        ResetInputReceiverReferences();
        GameObject hudDisplay = _MainDisplay.transform.Find("Hud").gameObject;
        _ActiveDisplay.HideDisplay();
        _ActiveDisplay = new UI_Hud(hudDisplay, _InputSwapper, _InputReceivers, this);
        _ActiveDisplay.ShowDisplay();
    }

    public void TransitionToGameMenu() {
        /*
        *@Desc: Will create and display the game menu, but first will disable the old UI display and reset the input receivers references
        */
        ResetInputReceiverReferences();
        GameObject gameMenuDisplay = _MainDisplay.transform.Find("Game Menu").gameObject;
        _ActiveDisplay.HideDisplay();
        _ActiveDisplay = new UI_GameMenu(gameMenuDisplay, _InputReceivers, this);
        _ActiveDisplay.ShowDisplay();
    }

    public void TransitionToOptionsMenu() {
        /*
        *@Desc: Will create and display the options menu, but first will disable the old UI display and reset the input receivers references
        */
        ResetInputReceiverReferences();
        GameObject optionsMenuDisplay = _MainDisplay.transform.Find("Options Menu").gameObject;
        _ActiveDisplay.HideDisplay();
        _ActiveDisplay = new UI_OptionsMenu(optionsMenuDisplay, _InputReceivers, this);
        _ActiveDisplay.ShowDisplay();
    }

    public void TransitionToPlayerMenu() {
        /*
        *@Desc: Will create and display the player menu, but first will disable the old UI display and reset the input receivers references
        */
        ResetInputReceiverReferences();
        GameObject optionsMenuDisplay = _MainDisplay.transform.Find("Player Menu").gameObject;
    }
}
