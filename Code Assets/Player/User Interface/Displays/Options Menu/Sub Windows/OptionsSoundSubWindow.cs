using UnityEngine;

public class OptionsSoundSubWindow : ISubWindowDisplayUI {
    private Animator _SubWindowButtonAnimator;
    private GameObject _SoundSubWindowDisplay;
    private Strategy_NavigateSubWindowBasic _SubWindowNavigationStrategy;

    public Strategy_NavigateSubWindowBasic SubWindowNavigationStrategy { get => _SubWindowNavigationStrategy; }

    public OptionsSoundSubWindow(GameObject display, GameObject menuBarButton, IGetReceiverFunctionality inputReceivers, UI_OptionMenuSubWindowTransitions transitions) {
        _SoundSubWindowDisplay = display;
        _SubWindowButtonAnimator = menuBarButton.GetComponent<Animator>();
        _SubWindowNavigationStrategy = new Strategy_NavigateSubWindowBasic(_SubWindowButtonAnimator, inputReceivers, transitions.TransitionToSoundSubWindow);
    }

    public void ShowSubWindowDisplay() {
        /*
         *@Desc: Display the Sound sub window in the Options Menu's display
        */
        _SoundSubWindowDisplay.SetActive(true);
    }

    public void HideSubWindowDisplay() {
        /*
         *@Desc: Hide the Sound sub window in the Options Menu's display
        */
        _SoundSubWindowDisplay.SetActive(false);
    }
}
