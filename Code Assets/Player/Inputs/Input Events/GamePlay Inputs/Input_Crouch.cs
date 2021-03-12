public class Input_Crouch {
    private IInputProxies _CrouchProxy;

    public Input_Crouch(IInputProxies crouchProxy) {
        _CrouchProxy = crouchProxy;
    }

    public void InputStart() {
        /**
          * @desc Inform the crouch proxy that the B button is pressed down
        */
        _CrouchProxy.InputActive();
    }

    public void InputEnd() {
        /**
          * @desc Inform the crouch proxy that the B button has been released
        */
        _CrouchProxy.InputInactive();
    }
}
