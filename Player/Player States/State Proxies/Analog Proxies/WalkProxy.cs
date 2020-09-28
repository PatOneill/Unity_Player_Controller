public class WalkProxy : IStateProxyOnOff, IDynamicProxy {
    private readonly IStateProxy _StatePlayer;
    private readonly IToggleProxySprintMediator _SprintToggleMediator;
    private bool _IsInputActive;

    public WalkProxy(IStateProxy playerState, IToggleProxySprintMediator sprintProxyToggleMediator) {
        _IsInputActive = false;
        _StatePlayer = playerState;
        _SprintToggleMediator = sprintProxyToggleMediator;
    }

    public void CheckActivation() {
        if (_IsInputActive) { //Check to see if proxy can become active
            ActiveProxy(); //Proxy is acitve
        } else {
            DeactivateProxy(); //Proxy is inactive 
            _SprintToggleMediator.CancelSprintToggle(); //Send a messages to the sprint proxy informing it that it has been decactivated by the walk proxy
        }
    }

    public void ProxyOn() {
        _IsInputActive = true;
        CheckActivation(); //Check to see if the proxy can become active/inactive
    }

    public void ProxyOff() {
        _IsInputActive = false;
        CheckActivation(); //Check to see if the proxy can become active/inactive
    }

    public void ActiveProxy() {
        _StatePlayer.AddActiveProxy(this); //Add this proxy to the list of active proxy in PlayerState
    }

    public void DeactivateProxy() {
        RetractRequest(); //Cancel this state's impact on the current active state
        _StatePlayer.RemoveInactiveProxy(this); //Remove this proxy from the list of active proxy in PlayerState
    }

    public void SendRequest() {
        _StatePlayer.CurrentPlayerState().Walk(); //Send state change request to the current active state
    }

    public void RetractRequest() {
        _StatePlayer.CurrentPlayerState().CancelWalk(); //Retract state change request to the current active state
    }
}
