public interface IUISubmitMediator {
    IUIActiveReceiver SetSubmissionReceiver {
        set;
    }
    void SubmissionActive();
    void SubmissionInactive();
}
