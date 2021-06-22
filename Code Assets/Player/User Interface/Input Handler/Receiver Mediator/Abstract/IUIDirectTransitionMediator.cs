public interface IUIDirectTransitionMediator {
    IUIActiveReceiver SetDirectTransitionReceiver {
        set;
    }
    void DirectTransitionActive();
    void DirectTransitionInactive();
}
