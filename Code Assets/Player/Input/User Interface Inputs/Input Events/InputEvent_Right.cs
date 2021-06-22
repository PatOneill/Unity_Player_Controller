public class InputEvent_Right : IInputHoldStart, IInputHoldPerform, IInputHoldCancel, IInputUINavigationRightCommand {
    private IUINavigateCommand _UIRightCommaand;

    public IUINavigateCommand SetUINavigationRightCommand { set => _UIRightCommaand = value; }

    public InputEvent_Right() {
        _UIRightCommaand = null;
    }

    public void HoldInputEventStart(float value) {
        /*
         * @Desc: Captuers the initial changes in the analog stick and or button assigned to the input event Right and update the command's PressValue
         * @Param: float value - This parameter represents the current position of the analog stick and or button on the user's controller
        */
        _UIRightCommaand.PressValue = value;
        _UIRightCommaand.Execute();
    }

    public void HoldInputEventPeform(float value) {
        /*
         * @Desc: Captuers all additional changes in the analog stick and or button assigned to the input event Right and update the command's PressValue
         * @Param: float value - This parameter represents the current position of the analog stick and or button on the user's controller.
         * @NOTE: If the button/stick is unmoved for a certain period of time, this method will not be called until its position is changed
        */
        _UIRightCommaand.PressValue = value;
        _UIRightCommaand.Execute();
    }

    public void HoldInputEventCancel() {
        /*
         * @Desc: Retracts the command when the analog stick and or button assigned to the input event Right has returned to its resting position
        */
        _UIRightCommaand.PressValue = 0.0f;
        _UIRightCommaand.Reverse();
    }
}
