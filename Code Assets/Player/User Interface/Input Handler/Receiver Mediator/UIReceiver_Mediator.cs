public class UIReceiver_Mediator : IUISubWindowMediator, IUISubmitMediator, IUINavigationMediator, IUIDirectTransitionMediator {
    private IUIActiveReceiver _NavigationReceiver;
    private IUIActiveReceiver _SubmissionReceiver;
    private IUIActiveReceiver _DirectTransitionReceiver;
    private IUIActiveReceiver _SubWindowReceiver;

    public IUIActiveReceiver SetNavigationReceiver { set => _NavigationReceiver = value; }
    public IUIActiveReceiver SetSubmissionReceiver { set => _SubmissionReceiver = value; }
    public IUIActiveReceiver SetDirectTransitionReceiver { set => _DirectTransitionReceiver = value; }
    public IUIActiveReceiver SetSubWindowReceiver { set => _SubWindowReceiver = value; }

    public UIReceiver_Mediator() {
        _NavigationReceiver = null;
        _SubmissionReceiver = null;
        _DirectTransitionReceiver = null;
    }

    public void SubmissionActive() {
        /*
         *@Desc: If a submission input action is the first to be registered, inform certain input receivers that they should ignore all incoming input action request
        */
        _NavigationReceiver.IsUIReceivingInputCommands = false;
        _DirectTransitionReceiver.IsUIReceivingInputCommands = false;
        _SubWindowReceiver.IsUIReceivingInputCommands = false;
        _SubmissionReceiver.IsUIReceivingInputCommands = false; //Prevent the user from submitting multiple times while the current submission is loading
    }

    public void SubmissionInactive() {
        /*
         *@Desc: Once the submission input action is done executing its functionality, inform certain input receivers that they can once again process incoming input action request
        */
        _NavigationReceiver.IsUIReceivingInputCommands = true;
        _DirectTransitionReceiver.IsUIReceivingInputCommands = true;
        _SubWindowReceiver.IsUIReceivingInputCommands = true;
        _SubmissionReceiver.IsUIReceivingInputCommands = true;
    }

    public void NavigationActive() {
        /*
         *@Desc: If a navigation input action is the first to be registered, inform certain input receivers that they should ignore all incoming input action request
        */
        _SubmissionReceiver.IsUIReceivingInputCommands = false;
        _SubWindowReceiver.IsUIReceivingInputCommands = false;
    }

    public void NavigationInactive() {
        /*
         *@Desc: Once the navigation input action is done executing its functionality, inform certain input receivers that they can once again process incoming input action request
        */
        _SubmissionReceiver.IsUIReceivingInputCommands = true;
        _SubWindowReceiver.IsUIReceivingInputCommands = true;
    }

    public void DirectTransitionActive() {
        /*
         *@Desc: If a direct transition input action is the first to be registered, inform certain input receivers that they should ignore all incoming input action request
        */
        _NavigationReceiver.IsUIReceivingInputCommands = false;
        _SubmissionReceiver.IsUIReceivingInputCommands = false;
    }

    public void DirectTransitionInactive() {
        /*
         *@Desc: Once the direct transition input action is done executing its functionality, inform certain input receivers that they can once again process incoming input action request
        */
        _NavigationReceiver.IsUIReceivingInputCommands = true;
        _SubmissionReceiver.IsUIReceivingInputCommands = true;
    }

    public void SubWindowActive() {
        /*
         *@Desc: If a sub window input action is the first to be registered, inform certain input receivers that they should ignore all incoming input action request
        */
        _NavigationReceiver.IsUIReceivingInputCommands = false;
        _SubmissionReceiver.IsUIReceivingInputCommands = false;
    }

    public void SubWindowInactive() {
        /*
         *@Desc: Once the sub window input action is done executing its functionality, inform certain input receivers that they can once again process incoming input action request
        */
        _NavigationReceiver.IsUIReceivingInputCommands = true;
        _SubmissionReceiver.IsUIReceivingInputCommands = true;
    }
}
