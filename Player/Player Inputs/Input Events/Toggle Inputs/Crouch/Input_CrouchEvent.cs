public class Input_CrouchEvent : IToggleInput {
    private readonly IInputProxyToggle _ProxyCrouch;
    private bool _IsToggled;

    public Input_CrouchEvent(IInputProxyToggle crouchProxy) {
        _IsToggled = false;
        _ProxyCrouch = crouchProxy;
        _ProxyCrouch.GetCommand().SetInput(this);
    }

    public void TogglePressed() {
        _IsToggled = !_IsToggled;
        if (_IsToggled) { //Check to see if the user is requesting to cancel crouch or activate crouch
            _ProxyCrouch.ProxyOn(); //Inform the crouch state proxy that the player wants to enter the crouching state
        } else {
            _ProxyCrouch.ProxyOff(); //Inform the crouch state proxy that the player wants to leave the crouching state
        }
    }

    public void CancelMessageFromProxy() {
        _IsToggled = false; //The crouch proxy has been disabled by another proxy and the toggle input must be updated accordingly
    }
}
