public class InputEvent_ShiftSubWindowRight : IInputButtonCancel, IInputUISubWindowShiftRightCommand {
    private IUIIrreversibleCommand _ShiftSubWindowRightCommand;

    public InputEvent_ShiftSubWindowRight() {
        _ShiftSubWindowRightCommand = null;
    }

    public IUIIrreversibleCommand SetSubWindowShiftRightCommand { set => _ShiftSubWindowRightCommand = value; }

    public void ButtonInputEventCanceled() {
        /*
         *@Desc: Notifies the UI input receiver for sub window shifting using a command that the user is attempting to make a shifting sub window request
        */
        _ShiftSubWindowRightCommand.Execute();
    }
}
