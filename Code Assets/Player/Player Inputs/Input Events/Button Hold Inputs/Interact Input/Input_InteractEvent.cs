public class Input_InteractEvent : IButtonHoldInput {
    private readonly IStateProxyOnOff _ProxyItemInteract;

    public Input_InteractEvent(IStateProxyOnOff interactProxy) {
        _ProxyItemInteract = interactProxy;
    }

    public void ButtonStart() {
        _ProxyItemInteract.ProxyOn(); //The player has pressed the button so activate the proxy 
    }

    public void ButtonCancel() {
        _ProxyItemInteract.ProxyOff(); //The player has released the button so deactivate the proxy 
    }
}
