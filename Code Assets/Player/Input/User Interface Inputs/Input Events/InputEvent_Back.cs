public class InputEvent_Back : IInputButtonCancel, IInputUITransitionBackCommand {
    private IUIIrreversibleCommand _TransitionToBackCommand;

    public IUIIrreversibleCommand SetUITransitionBackCommand { set => _TransitionToBackCommand = value; }

    public InputEvent_Back() {
        _TransitionToBackCommand = null;
    }

    public void ButtonInputEventCanceled() {
        /*
         * @Desc: Send a request to the UI system to display the previous display
         * @NOTE: The execution of this method does not guarantee that the UI display of the previous display will always appear. Check UI system for more details
        */
        _TransitionToBackCommand.Execute();
    }
}
