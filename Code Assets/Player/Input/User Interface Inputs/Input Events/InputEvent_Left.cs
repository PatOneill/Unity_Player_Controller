public class InputEvent_Left : IInputHoldStart, IInputHoldPerform, IInputHoldCancel, IInputUINavigationLeftCommand {
    private IUINavigateCommand _UILeftCommaand;

    public IUINavigateCommand SetUINavigationLeftCommand { set => _UILeftCommaand = value; }

    public InputEvent_Left() {
        _UILeftCommaand = null;
    }

    public void HoldInputEventStart(float value) {
        /*
         * @Desc: Captuers the initial changes in the analog stick and or button assigned to the input event Left and update the command's PressValue
         * @Param: float value - This parameter represents the current position of the analog stick and or button on the user's controller
        */
        _UILeftCommaand.PressValue = value;
        _UILeftCommaand.Execute();
    }

    public void HoldInputEventPeform(float value) {
        /*
         * @Desc: Captuers all additional changes in the analog stick and or button assigned to the input event Left and update the command's PressValue
         * @Param: float value - This parameter represents the current position of the analog stick and or button on the user's controller.
         * @NOTE: If the button/stick is unmoved for a certain period of time, this method will not be called until its position is changed
        */
        _UILeftCommaand.PressValue = value;
        _UILeftCommaand.Execute();
    }

    public void HoldInputEventCancel() {
        /*
         * @Desc: Retracts the command when the analog stick and or button assigned to the input event Left has returned to its resting position
        */
        _UILeftCommaand.PressValue = 0.0f;
        _UILeftCommaand.Reverse();
    }
}
