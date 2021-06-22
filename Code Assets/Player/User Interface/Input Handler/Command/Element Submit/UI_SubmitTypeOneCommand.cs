public class UI_SubmitTypeOneCommand : IUIIrreversibleCommand {
    private IElementSubmitTypeOneCommand _CommandReceiver;

    public UI_SubmitTypeOneCommand(IElementSubmitTypeOneCommand receiver) {
        _CommandReceiver = receiver;
    }

    public void Execute() {
        /*
         *@Desc: Inform the receiver associated with submit type one command that the input assigned to this command is currently active
        */
        _CommandReceiver.SubmitTypeOneEvent();
    }
}
