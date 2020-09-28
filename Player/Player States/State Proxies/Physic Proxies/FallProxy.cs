public class FallProxy : IStateProxyOnOff, IDynamicProxy {
    private readonly IStateProxy _StatePlayer;
    private bool _IsPhysicsActive;

    public FallProxy(IStateProxy playerState) {
        _IsPhysicsActive = false;
        _StatePlayer = playerState;
    }

    public void CheckActivation() {
        if (_IsPhysicsActive) { //Check to see if proxy can become active
            ActiveProxy(); //Proxy is acitve
        } else {
            DeactivateProxy(); //Proxy is inactive 
        }
    }

    public void ProxyOn() {
        _IsPhysicsActive = true;
        CheckActivation(); //Check to see if the proxy can become active/inactive
    }

    public void ProxyOff() {
        _IsPhysicsActive = false;
        CheckActivation(); //Check to see if the proxy can become active/inactive
    }

    public void ActiveProxy() {
        _StatePlayer.AddActiveProxy(this); //Add this proxy to the list of active proxy in PlayerState
    }

    public void DeactivateProxy() {
        _StatePlayer.RemoveInactiveProxy(this); //Remove this proxy from the list of active proxy in PlayerState
        RetractRequest(); //Cancel this state's impact on the current active state
    }

    public void SendRequest() {
        _StatePlayer.CurrentPlayerState().Fall(); //Send state change request to the current active state
    }

    public void RetractRequest() {
        _StatePlayer.CurrentPlayerState().CancelFall(); //Retract state change request to the current active state
    }
}
