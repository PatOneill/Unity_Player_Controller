public class UI_TransitionToBack : IUIIrreversibleCommand {
    private IDirectTransitionBack _CommandReceiver;

    public UI_TransitionToBack(IDirectTransitionBack receiver) {
        _CommandReceiver = receiver;
    }

    public void Execute() {
        /*
         *@Desc: Inform the receiver associated with the direct transition to back command that the input assigned to this command is currently active
        */
        _CommandReceiver.TransitionToBack();
    }
}
