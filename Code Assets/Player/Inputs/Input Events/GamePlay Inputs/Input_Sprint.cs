public class Input_Sprint {
    private IInputProxies _SprintProxy;

    public Input_Sprint(IInputProxies sprintProxy) {
        _SprintProxy = sprintProxy;
    }

    public void InputStart() {
        /**
          * @desc Inform the sprint proxy that the left stick  has been pressed down
        */
        _SprintProxy.InputActive();
    }

    public void InputEnd() {
        /**
          * @desc Inform the sprint proxy that the player is no longer being held down the left stick
        */
        _SprintProxy.InputInactive();
    }
}
