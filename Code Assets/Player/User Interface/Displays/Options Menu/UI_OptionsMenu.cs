using UnityEngine;

public class UI_OptionsMenu : ADisplayReceivers, IDisplayUI {
    private GameObject _OptionsMenuDisplay;
    private ISubWindowDisplayTransitions _OptionsMenuSubWindowTransitions;
    private IGetReceiverFunctionality _InputReceiver;

    public UI_OptionsMenu(GameObject display, IGetReceiverFunctionality inputReceivers, UI_DisplayTransitions transitions) {
        _OptionsMenuDisplay = display;
        _InputReceiver = inputReceivers;
        GameObject tempBackground = _OptionsMenuDisplay.transform.Find("Background").gameObject;
        GameObject tempMenuBar = tempBackground.transform.Find("Menu Bar").gameObject;
        _OptionsMenuSubWindowTransitions = new UI_OptionMenuSubWindowTransitions(tempBackground, tempMenuBar, inputReceivers);

        SetupInputReceivers(inputReceivers, transitions);
    }

    protected override void SetupInputReceivers(IGetReceiverFunctionality inputReceivers, UI_DisplayTransitions transitions) {
        IReceiverDirectTransitionHandler directTransitions = inputReceivers.GetDirectTransitionReceiver;
        directTransitions.SetBackTransitionStrategy = new Strategy_TransitionToPreviousDisplayToGameMenu(transitions);
        directTransitions.SetGameMenuTransitionStrategy = new Strategy_GameMenuTransitionGoTo(transitions);
        directTransitions.SetPlayerMenuTransitionStrategy = new Strategy_PlayerMenuTransitionIgnore();
    }

    public void ShowDisplay() {
        /*
         *@Desc: Shows the user the Options Menu display and sets up additional UI display elements related to the sub window
        */
        _OptionsMenuDisplay.SetActive(true);
        _OptionsMenuSubWindowTransitions.OnDisplay();
    }

    public void HideDisplay() {
        /*
         *@Desc: Hides the Options Menu display from the user and cleans up display elements related to the sub window
        */
        _OptionsMenuDisplay.SetActive(false);
        _OptionsMenuSubWindowTransitions.OnClose();
    }
}
