public class InputEvent_SubmitTypeThree : IInputButtonCancel, IInputSubmissionTypeThreeCommand {
    private IUIIrreversibleCommand _SubmitTypeThreeCommand;

    public InputEvent_SubmitTypeThree() {
        _SubmitTypeThreeCommand = null;
    }

    public IUIIrreversibleCommand SetSubmitTypeThreeCommand { set => _SubmitTypeThreeCommand = value; }

    public void ButtonInputEventCanceled() {
        /*
         *@Desc: Notifies the UI input receiver for submission requests using a command that the user is attempting to make a submission type three request
        */
        _SubmitTypeThreeCommand.Execute();
    }
}
