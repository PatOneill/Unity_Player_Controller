using UnityEngine;

public class OptionsGameplaySubWindow : ISubWindowDisplayUI {
    private Animator _SubWindowButtonAnimator;
    private GameObject _GameplaySubWindowDisplay;
    private Strategy_NavigateSubWindowBasic _SubWindowNavigationStrategy;

    public Strategy_NavigateSubWindowBasic SubWindowNavigationStrategy { get => _SubWindowNavigationStrategy; }

    public OptionsGameplaySubWindow(GameObject display, GameObject menuBarButton, IGetReceiverFunctionality inputReceivers, UI_OptionMenuSubWindowTransitions transitions) {
        _GameplaySubWindowDisplay = display;
        _SubWindowButtonAnimator = menuBarButton.GetComponent<Animator>();
        _SubWindowNavigationStrategy = new Strategy_NavigateSubWindowBasic(_SubWindowButtonAnimator, inputReceivers, transitions.TransitionToGameplaySubWindow);
    }

    public void ShowSubWindowDisplay() {
        /*
         *@Desc: Display the Gameplay sub window in the Options Menu's display
        */
        _GameplaySubWindowDisplay.SetActive(true);
    }

    public void HideSubWindowDisplay() {
        /*
         *@Desc: Hide the Gameplay sub window in the Options Menu's display
        */
        _GameplaySubWindowDisplay.SetActive(false);
    }
}
