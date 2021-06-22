using UnityEngine;

public class Strategy_NavigateElementBasic : IUIElementNavigation {
    private Animator _ButtonAnimator;
    private IReceiverHandleElementNavigation _UIElementNavigationReceiver;
    private IElementSubmissionTypeSetup _UIElementSubmissionSetup;
    private IUIElementNavigation _UpElement;
    private IUIElementNavigation _DownElement;
    private IUIElementNavigation _LeftElement;
    private IUIElementNavigation _RightElement;
    
    public Strategy_NavigateElementBasic(Animator buttonAnimator, IGetReceiverFunctionality inputReceivers, IElementSubmissionTypeSetup submissionSetup) {
        _ButtonAnimator = buttonAnimator;
        _UIElementNavigationReceiver = inputReceivers.GetUIElementNavigationReceiver;
        _UIElementSubmissionSetup = submissionSetup;
        _UpElement = null;
        _DownElement = null;
        _LeftElement = null;
        _RightElement = null;
    }

    public void SetupElementNavigation(IUIElementNavigation upElement = null, IUIElementNavigation downElement = null, IUIElementNavigation leftElement = null, IUIElementNavigation rightElement = null) {
        _UpElement = upElement;
        _DownElement = downElement;
        _LeftElement = leftElement;
        _RightElement = rightElement;
    }

    public void NavigateUp() {
        /*
         *@Desc: If there is an above element assigned to the current selected element, allow the element above to be selected, while this element becomes unselected
        */
        if (_UpElement == null) { return; }
        this.ElementUnselected();

        _UpElement.ElementSelected();
    }

    public void NavigateDown() {
        /*
         *@Desc: If there is a below element assigned to the current selected element, allow the element below to be selected, while this element becomes unselected
        */
        if (_DownElement == null) { return; }
        this.ElementUnselected();

        _DownElement.ElementSelected();
    }

    public void NavigateLeft() {
        /*
         *@Desc: If there is a left element assigned to the current selected element, allow the element to the left to be selected, while this element becomes unselected
        */
        if (_LeftElement == null) { return; }
        this.ElementUnselected();

        _LeftElement.ElementSelected();
    }

    public void NavigateRight() {
        /*
         *@Desc: If there is a right element assigned to the current selected element, allow the element to the right to be selected, while this element becomes unselected
        */
        if (_RightElement == null) { return; }
        this.ElementUnselected();

        _RightElement.ElementSelected();
    }

    public void ElementSelected() {
        /*
         *@Desc: When an element becomes selected, play the animation of selection, and inform the submission receiver what types of submission this button accepts
        */
        _ButtonAnimator.SetBool("Selected", true);
        _UIElementNavigationReceiver.SetUIElementNavigationStrategy = this; //Inform the element navigation receiver that a new element has been selected and should respond to user input
        _UIElementSubmissionSetup.SetupSubmissionTypes(); //Update receivers on submission types
    }

    public void ElementUnselected() {
        /*
         *@Desc: When an element becomes unselected, play the animation of unselection, and inform the submission receiver that this button is no longer accepting certain submissions
        */
        _UIElementSubmissionSetup.CleanSubmissionTypes();
        _ButtonAnimator.SetBool("Selected", false);
    }
}
