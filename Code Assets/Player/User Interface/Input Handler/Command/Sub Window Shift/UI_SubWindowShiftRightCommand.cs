public class UI_SubWindowShiftRightCommand : IUIIrreversibleCommand {
    private ISubWindowShiftRight _CommandReceiver;

    public UI_SubWindowShiftRightCommand(ISubWindowShiftRight receiver) {
        _CommandReceiver = receiver;
    }

    public void Execute() {
        /*
         *@Desc: Inform the receiver associated with the sub window shift right command that the input assigned to this command is currently active
        */
        _CommandReceiver.ShiftSubWindowRight();
    }
}
