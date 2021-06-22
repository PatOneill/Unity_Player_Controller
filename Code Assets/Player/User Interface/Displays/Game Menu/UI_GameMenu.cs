using UnityEngine;

public class UI_GameMenu : ADisplayReceivers, IDisplayUI {
    private GameObject _GameMenuDisplay;
    private IGetReceiverFunctionality _InputReceiver;
    private UIElement_ResumeButton _ResumeButton;
    private UIElement_OptionsButton _OptionsButton;
    private UIElement_QuitButton _QuitButton;

    public UI_GameMenu(GameObject display, IGetReceiverFunctionality inputReceivers, UI_DisplayTransitions transitions) {
        _GameMenuDisplay = display;
        _InputReceiver = inputReceivers;
        GameObject tempBackground = _GameMenuDisplay.transform.Find("Background").gameObject;
        _ResumeButton = new UIElement_ResumeButton(tempBackground, inputReceivers, transitions);
        _OptionsButton = new UIElement_OptionsButton(tempBackground, inputReceivers, transitions);
        _QuitButton = new UIElement_QuitButton(tempBackground, inputReceivers, transitions);

        _ResumeButton.ButtonNavigationStrategy.SetupElementNavigation(downElement: _OptionsButton.ButtonNavigationStrategy);
        _OptionsButton.ButtonNavigationStrategy.SetupElementNavigation(upElement: _ResumeButton.ButtonNavigationStrategy, downElement: _QuitButton.ButtonNavigationStrategy);
        _QuitButton.ButtonNavigationStrategy.SetupElementNavigation(upElement: _OptionsButton.ButtonNavigationStrategy);

        SetupInputReceivers(inputReceivers, transitions);
    }

    protected override void SetupInputReceivers(IGetReceiverFunctionality inputReceivers, UI_DisplayTransitions transitions) {
        IReceiverDirectTransitionHandler directTransitions = inputReceivers.GetDirectTransitionReceiver;
        directTransitions.SetBackTransitionStrategy = new Strategy_TransitionToPreviousDisplayToHud(transitions);
        directTransitions.SetGameMenuTransitionStrategy = new Strategy_GameMenuTransitionToHud(transitions);
        directTransitions.SetPlayerMenuTransitionStrategy = new Strategy_PlayerMenuTransitionIgnore();

        IReceiverHandleElementNavigation elementNavigation = inputReceivers.GetUIElementNavigationReceiver;
        elementNavigation.SetUIElementNavigationStrategy = _ResumeButton.ButtonNavigationStrategy;
    }

    public void ShowDisplay() {
        /*
         *@Desc: Shows the user the Game Menu display and sets up additional UI display elements
        */
        _GameMenuDisplay.SetActive(true);
        _ResumeButton.ButtonNavigationStrategy.ElementSelected(); //When the game menu is opened, set the resume button as the default selected button
    }

    public void HideDisplay() {
        /*
         *@Desc: Hides the Game Menu display from the user
        */
        _GameMenuDisplay.SetActive(false);
    }
}
