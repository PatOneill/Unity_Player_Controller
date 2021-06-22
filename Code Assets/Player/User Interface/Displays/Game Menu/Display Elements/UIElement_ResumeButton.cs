using UnityEngine;

public class UIElement_ResumeButton : IElementSubmissionTypeSetup {
    private Animator _ButtonAnimator;
    private Strategy_NavigateElementBasic _ButtonNavigationStrategy;
    private UI_DisplayTransitions _PossibleWindowTransitions;
    private IReceiverHandleElementSubmission _SubmissionReceiver;
    public Strategy_NavigateElementBasic ButtonNavigationStrategy { get => _ButtonNavigationStrategy; }

    public UIElement_ResumeButton(GameObject display, IGetReceiverFunctionality inputReceivers, UI_DisplayTransitions transitions) {
        _ButtonAnimator = display.transform.Find("Resume Button").gameObject.GetComponent<Animator>();
        _SubmissionReceiver = inputReceivers.GetUIElementSubmissionReceiver;
        _PossibleWindowTransitions = transitions;
        _ButtonNavigationStrategy = new Strategy_NavigateElementBasic(_ButtonAnimator, inputReceivers, this);
    }

    public void SetupSubmissionTypes() {
        /*
         *@Desc: When a button becomes selected, inform the receiver for submission about how this button will react if certain submission request come through
        */
        _SubmissionReceiver.SetUIElementSubmissionTypeOneStrategy = new Strategy_ElementSubmissionTypeOneDisplayTransition(_ButtonAnimator, _PossibleWindowTransitions.TransitionToHud);
    }

    public void CleanSubmissionTypes() {
        /*
         *@Desc: When a button becomes unselected, inform the receiver for submission that this button is no longer taking submission request
        */
        _SubmissionReceiver.SetUIElementSubmissionTypeOneStrategy = new Strategy_ElementSubmissionTypeOneIgnore();
    }
}
