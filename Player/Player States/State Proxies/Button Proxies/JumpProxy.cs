public class JumpProxy : IStateProxyOn, IDynamicProxy {
    private readonly IStateProxy _StatePlayer;
    private readonly IToggleProxyCrouchMediator _CrouchToggleMediator;
    private bool _IsInputActive;

    public JumpProxy(IStateProxy playerState, IToggleProxyCrouchMediator crouchProxyToggleMediator) {
        _IsInputActive = false;
        _StatePlayer = playerState;
        _CrouchToggleMediator = crouchProxyToggleMediator;
    }

    public void CheckActivation() {
        if (_IsInputActive) { //Check to see if proxy can become active
            ActiveProxy(); //Proxy is acitve
            _CrouchToggleMediator.CancelCrouchToggle(); //Send a messages to the crouch proxy informing it that it has been decactivated by the jump proxy
        } else {
            DeactivateProxy(); //Proxy is inactive 
        }
    }

    public void ProxyOn() {
        _IsInputActive = true;
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
        _StatePlayer.CurrentPlayerState().Jump(); //Send state change request to the current active state
    }

    public void RetractRequest() {
        _StatePlayer.CurrentPlayerState().CancelJump(); //Retract state change request to the current active state
    }
}
