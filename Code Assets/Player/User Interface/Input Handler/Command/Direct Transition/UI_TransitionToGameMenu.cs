public class UI_TransitionToGameMenu : IUIIrreversibleCommand {
    private IDirectTransitionGameMenu _CommandReceiver;

    public UI_TransitionToGameMenu(IDirectTransitionGameMenu receiver) {
        _CommandReceiver = receiver;
    }

    public void Execute() {
        /*
         *@Desc: Inform the receiver associated with the direct transition to game menu command that the input assigned to this command is currently active
        */
        _CommandReceiver.TransitionToGameMenu();
    }
}
