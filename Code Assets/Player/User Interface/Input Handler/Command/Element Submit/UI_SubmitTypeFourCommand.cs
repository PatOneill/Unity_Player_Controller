public class UI_SubmitTypeFourCommand : IUICommand {
    private IElementSubmitTypeFourCommand _CommandReceiver;

    public UI_SubmitTypeFourCommand(IElementSubmitTypeFourCommand receiver) {
        _CommandReceiver = receiver;
    }

    public void Execute() {
        /*
         *@Desc: Inform the receiver associated with submit type four command that the input assigned to this command has just become active
        */
        _CommandReceiver.SubmitTypeFourStartEvent();
    }

    public void Reverse() {
        /*
         *@Desc: Inform the receiver associated with submit type four command that the input assigned to this command is no longer active
        */
        _CommandReceiver.SubmitTypeFourEndEvent();
    }
}
