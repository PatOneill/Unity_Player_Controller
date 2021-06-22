public class InputEvent_Up : IInputHoldStart, IInputHoldPerform, IInputHoldCancel, IInputUINavigationUpCommand {
    private IUINavigateCommand _UIUpCommaand;

    public IUINavigateCommand SetUINavigationUpCommand { set => _UIUpCommaand = value; }

    public InputEvent_Up() {
        _UIUpCommaand = null;
    }

    public void HoldInputEventStart(float value) {
        /*
         * @Desc: Captuers the initial changes in the analog stick and or button assigned to the input event Up and update the command's PressValue
         * @Param: float value - This parameter represents the current position of the analog stick and or button on the user's controller
        */
        _UIUpCommaand.PressValue = value;
        _UIUpCommaand.Execute();
    }

    public void HoldInputEventPeform(float value) {
        /*
         * @Desc: Captuers all additional changes in the analog stick and or button assigned to the input event Up and update the command's PressValue
         * @Param: float value - This parameter represents the current position of the analog stick and or button on the user's controller
         * @NOTE: If the button/stick is unmoved for a certain period of time, this method will not be called until its position is changed
        */
        _UIUpCommaand.PressValue = value;
        _UIUpCommaand.Execute();
    }

    public void HoldInputEventCancel() {
        /*
         * @Desc: Retracts the command when the analog stick and or button assigned to the input event Up has returned to its resting position
        */
        _UIUpCommaand.PressValue = 0.0f;
        _UIUpCommaand.Reverse();
    }
}
