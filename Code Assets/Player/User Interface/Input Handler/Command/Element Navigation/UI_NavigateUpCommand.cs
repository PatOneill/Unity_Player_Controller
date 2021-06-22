public class UI_NavigateUpCommand : IUINavigateCommand {
    private IDirectionalCommandUp _CommandReceiver;
    private float _PressValue; //Represents the anlog stick's position
    public float PressValue { set => _PressValue = value; }

    public UI_NavigateUpCommand(IDirectionalCommandUp reveiver) {
        _PressValue = 0.0f;
        _CommandReceiver = reveiver;
    }

    public void Execute() {
        /*
         * @Desc: Inform the receiver associated with the navigate up command that the input assigned to this command is currently active
         * @NOTE: This method is called on every input update as the command is in monitoring an anlog stick's position and a button input as well
        */
        _CommandReceiver.MoveSelectedUIElementUp(_PressValue);
    }

    public void Reverse() {
        /*
         * @Desc: Inform the receiver associated with the navigate up command that the input assigned to this command is no longer active
        */
        _CommandReceiver.CancelSelectedUpCommand();
    }
}

