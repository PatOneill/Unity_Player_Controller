public class Input_SprintEvent : IToggleInput {
    private readonly IInputProxyToggle _ProxySprint;
    private bool _IsToggled;

    public Input_SprintEvent(IInputProxyToggle sprintProxy) {
        _IsToggled = false;
        _ProxySprint = sprintProxy;
        _ProxySprint.GetCommand().SetInput(this);
    }

    public void TogglePressed() {
        _IsToggled = !_IsToggled;
        if (_IsToggled) { //Check to see if the user is requesting to cancel sprint or activate sprint
            _ProxySprint.ProxyOn(); //Inform the state proxy that the player wants to enter the sprinting state
        } else {
            _ProxySprint.ProxyOff(); //Inform the state proxy that the player wants to leave the sprinting state
        }
    }

    public void CancelMessageFromProxy() {
        _IsToggled = false; //The sprint proxy has been disabled by another proxy and the toggle input must be updated accordingly
    }
}
