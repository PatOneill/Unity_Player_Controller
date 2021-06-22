public class InputEvent_ShiftSubWindowLeft : IInputButtonCancel, IInputUISubWindowShiftLeftCommand {
    private IUIIrreversibleCommand _ShiftSubWindowLeftCommand;

    public InputEvent_ShiftSubWindowLeft() {
        _ShiftSubWindowLeftCommand = null;
    }

    public IUIIrreversibleCommand SetSubWindowShiftLeftCommand { set => _ShiftSubWindowLeftCommand = value; }

    public void ButtonInputEventCanceled() {
        /*
         *@Desc: Notifies the UI input receiver for sub window shifting using a command that the user is attempting to make a shifting sub window request
        */
        _ShiftSubWindowLeftCommand.Execute();
    }
}
