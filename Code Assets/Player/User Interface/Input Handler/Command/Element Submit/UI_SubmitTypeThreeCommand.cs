public class UI_SubmitTypeThreeCommand : IUIIrreversibleCommand {
    private IElementSubmitTypeThreeCommand _CommandReceiver;

    public UI_SubmitTypeThreeCommand(IElementSubmitTypeThreeCommand receiver) {
        _CommandReceiver = receiver;
    }

    public void Execute() {
        /*
         *@Desc: Inform the receiver associated with submit type three command that the input assigned to this command is currently active
        */
        _CommandReceiver.SubmitTypeThreeEvent();
    }
}
