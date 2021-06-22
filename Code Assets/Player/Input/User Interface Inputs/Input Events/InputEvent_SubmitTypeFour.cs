public class InputEvent_SubmitTypeFour : IInputButtonStart, IInputButtonCancel, IInputSubmissionTypeFourCommand {
    private IUICommand _SubmitTypeFourCommand;

    public InputEvent_SubmitTypeFour() {
        _SubmitTypeFourCommand = null;
    }

    public IUICommand SetSubmitTypeFourCommand { set => _SubmitTypeFourCommand = value; }

    public void ButtonInputEventStarted() {
        /*
         *@Desc: Notifies the UI input receiver for submission requests using a command that the user is starting to make a submission type four request
        */
        _SubmitTypeFourCommand.Execute();
    }

    public void ButtonInputEventCanceled() {
        /*
         *@Desc: Notifies the UI input receiver for submission requests using a command that the user is done making a submission type four request
        */
        _SubmitTypeFourCommand.Reverse();
    }
}
