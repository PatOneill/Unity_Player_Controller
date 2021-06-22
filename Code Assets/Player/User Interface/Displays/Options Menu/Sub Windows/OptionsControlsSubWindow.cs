using UnityEngine;

public class OptionsControlsSubWindow : ISubWindowDisplayUI {
    private Animator _SubWindowButtonAnimator;
    private GameObject _ControlsSubWindowDisplay;
    private Strategy_NavigateSubWindowBasic _SubWindowNavigationStrategy;

    public Strategy_NavigateSubWindowBasic SubWindowNavigationStrategy { get => _SubWindowNavigationStrategy; }

    public OptionsControlsSubWindow(GameObject display, GameObject menuBarButton, IGetReceiverFunctionality inputReceivers, UI_OptionMenuSubWindowTransitions transitions) {
        _ControlsSubWindowDisplay = display;
        _SubWindowButtonAnimator = menuBarButton.GetComponent<Animator>();
        _SubWindowNavigationStrategy = new Strategy_NavigateSubWindowBasic(_SubWindowButtonAnimator, inputReceivers, transitions.TransitionToControlsSubWindow);
    }

    public void ShowSubWindowDisplay() {
        /*
         *@Desc: Display the Controls sub window in the Options Menu's display
        */
        _ControlsSubWindowDisplay.SetActive(true);
    }

    public void HideSubWindowDisplay() {
        /*
         *@Desc: Hide the Controls sub window in the Options Menu's display
        */
        _ControlsSubWindowDisplay.SetActive(false);
    }
}
