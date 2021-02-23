public class Input_BButton {
    private IInputProxies _CrouchProxy;

    public Input_BButton(IInputProxies crouchProxy) {
        _CrouchProxy = crouchProxy;
    }

    public void GamePlay_InputStart() {
        /**
          * @desc Inform the crouch proxy that the B button is pressed down
        */
        _CrouchProxy.InputActive();
    }

    public void GamePlay_InputEnd() {
        /**
          * @desc Inform the crouch proxy that the B button has been released
        */
        _CrouchProxy.InputInactive();
    }
}
