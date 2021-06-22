using UnityEngine;

public class OptionsVideoSubWindow : ISubWindowDisplayUI {
    private Animator _SubWindowButtonAnimator;
    private GameObject _VideoSubWindowDisplay;
    private Strategy_NavigateSubWindowBasic _SubWindowNavigationStrategy;

    public Strategy_NavigateSubWindowBasic SubWindowNavigationStrategy { get => _SubWindowNavigationStrategy; }

    public OptionsVideoSubWindow(GameObject display, GameObject menuBarButton, IGetReceiverFunctionality inputReceivers, UI_OptionMenuSubWindowTransitions transitions) {
        _VideoSubWindowDisplay = display;
        _SubWindowButtonAnimator = menuBarButton.GetComponent<Animator>();
        _SubWindowNavigationStrategy = new Strategy_NavigateSubWindowBasic(_SubWindowButtonAnimator, inputReceivers, transitions.TransitionToVideoSubWindow);
    }

    public void ShowSubWindowDisplay() {
        /*
         *@Desc: Display the Video sub window in the Options Menu's display
        */
        _VideoSubWindowDisplay.SetActive(true);
    }

    public void HideSubWindowDisplay() {
        /*
         *@Desc: Hide the Video sub window in the Options Menu's display
        */
        _VideoSubWindowDisplay.SetActive(false);
    }
}
