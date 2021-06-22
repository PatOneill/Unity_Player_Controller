public class InputEvent_PlayerMenu : IInputButtonCancel, IInputUITransitionPlayerMenuCommand {
    private IUIIrreversibleCommand _TransitionToPlayerMenuCommand;

    public IUIIrreversibleCommand SetUITransitionPlayerMenuCommand { set => _TransitionToPlayerMenuCommand = value; }

    public InputEvent_PlayerMenu() {
        _TransitionToPlayerMenuCommand = null;
    }

    public void ButtonInputEventCanceled() {
        /*
         * @Desc: Send a request to the UI system to display the Player Menu
         * @NOTE: The execution of this method does not guarantee that the UI display of Player Menu will always appear. Check UI system for more details
        */
        _TransitionToPlayerMenuCommand.Execute();
    }
}
