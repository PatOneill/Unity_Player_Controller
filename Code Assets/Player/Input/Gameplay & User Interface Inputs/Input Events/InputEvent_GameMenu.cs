public class InputEvent_GameMenu : IInputButtonCancel, IInputUITransitionGameMenuCommand {
    private IUIIrreversibleCommand _TransitionToGameMenuCommand;

    public IUIIrreversibleCommand SetUITransitionGameMenuCommand { set => _TransitionToGameMenuCommand = value; }

    public InputEvent_GameMenu() {
        _TransitionToGameMenuCommand = null;
    }

    public void ButtonInputEventCanceled() {
        /*
         * @Desc: Send a request to the UI system to display the Game Menu
         * @NOTE: The execution of this method does not guarantee that the UI display of Game Menu will always appear. Check UI system for more details
        */
        _TransitionToGameMenuCommand.Execute();
    }
}
