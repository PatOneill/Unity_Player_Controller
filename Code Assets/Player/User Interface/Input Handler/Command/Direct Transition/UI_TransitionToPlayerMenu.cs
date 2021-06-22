public class UI_TransitionToPlayerMenu : IUIIrreversibleCommand {
    private IDirectTransitionPlayerMenu _CommandReceiver;

    public UI_TransitionToPlayerMenu(IDirectTransitionPlayerMenu receiver) {
        _CommandReceiver = receiver;
    }

    public void Execute() {
        /*
         *@Desc: Inform the receiver associated with the direct transition to player menu command that the input assigned to this command is currently active
        */
        _CommandReceiver.TransitionToPlayerMenu();
    }
}
