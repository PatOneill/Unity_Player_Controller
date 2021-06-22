public class UI_SubWindowShiftLeftCommand : IUIIrreversibleCommand {
    private ISubWindowShiftLeft _CommandReceiver;

    public UI_SubWindowShiftLeftCommand(ISubWindowShiftLeft receiver) {
        _CommandReceiver = receiver;
    }

    public void Execute() {
        /*
         *@Desc: Inform the receiver associated with the sub window shift left command that the input assigned to this command is currently active
        */
        _CommandReceiver.ShiftSubWindowLeft();
    }
}
