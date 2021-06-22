public class InputEvent_Down : IInputHoldStart, IInputHoldPerform, IInputHoldCancel, IInputUINavigationDownCommand {
    private IUINavigateCommand _UIDownCommand;

    public IUINavigateCommand SetUINavigationDownCommand { set => _UIDownCommand = value; }

    public InputEvent_Down() {
        _UIDownCommand = null;
    }

    public void HoldInputEventStart(float value) {
        /*
         * @Desc: Captuers the initial changes in the analog stick and or button assigned to the input event Down and update the command's PressValue
         * @Param: float value - This parameter represents the current position of the analog stick and or button on the user's controller
        */
        _UIDownCommand.PressValue = value;
        _UIDownCommand.Execute();
    }

    public void HoldInputEventPeform(float value) {
        /*
         * @Desc: Captuers all additional changes in the analog stick and or button assigned to the input event Down and update the command's PressValue
         * @Param: float value - This parameter represents the current position of the analog stick and or button on the user's controller.
         * @NOTE: If the button/stick is unmoved for a certain period of time, this method will not be called until its position is changed
        */
        _UIDownCommand.PressValue = value;
        _UIDownCommand.Execute();
    }

    public void HoldInputEventCancel() {
        /*
         * @Desc: Retracts the command when the analog stick and or button assigned to the input event Down has returned to its resting position
        */
        _UIDownCommand.PressValue = 0.0f;
        _UIDownCommand.Reverse();
    }
}
