public class InputEvent_SubmitTypeTwo : IInputButtonCancel, IInputSubmissionTypeTwoCommand {
    private IUIIrreversibleCommand _SubmitTypeTwoCommand;

    public InputEvent_SubmitTypeTwo() {
        _SubmitTypeTwoCommand = null;
    }

    public IUIIrreversibleCommand SetSubmitTypeTwoCommand { set => _SubmitTypeTwoCommand = value; }

    public void ButtonInputEventCanceled() {
        /*
         *@Desc: Notifies the UI input receiver for submission requests using a command that the user is attempting to make a submission type two request
        */
        _SubmitTypeTwoCommand.Execute();
    }
}
