public class UI_SubmitTypeTwoCommand : IUIIrreversibleCommand {
    private IElementSubmitTypeTwoCommand _CommandReceiver;

    public UI_SubmitTypeTwoCommand(IElementSubmitTypeTwoCommand receiver) {
        _CommandReceiver = receiver;
    }

    public void Execute() {
        /*
         *@Desc: Inform the receiver associated with submit type two command that the input assigned to this command is currently active
        */
        _CommandReceiver.SubmitTypeTwoEvent();
    }
}
