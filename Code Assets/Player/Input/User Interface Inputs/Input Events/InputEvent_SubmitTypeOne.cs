public class InputEvent_SubmitTypeOne : IInputButtonCancel, IInputSubmissionTypeOneCommand {
    private IUIIrreversibleCommand _SubmitTypeOneCommand;

    public InputEvent_SubmitTypeOne() {
        _SubmitTypeOneCommand = null;
    }

    public IUIIrreversibleCommand SetSubmitTypeOneCommand { set => _SubmitTypeOneCommand = value; }

    public void ButtonInputEventCanceled() {
        /*
         *@Desc: Notifies the UI input receiver for submission requests using a command that the user is attempting to make a submission type one request
        */
        _SubmitTypeOneCommand.Execute();
    }
}
