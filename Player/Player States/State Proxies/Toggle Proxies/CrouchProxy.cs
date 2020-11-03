public class CrouchProxy : IInputProxyToggle, IDynamicProxy {
    private readonly IStateProxy _StatePlayer;
    private readonly IToggleProxySprintMediator _SprintToggleMediator;
    private bool _IsInputActive;
    private CrouchCommand _CommandCrouch;

    public CrouchProxy(IStateProxy playerState, IToggleProxySprintMediator sprintProxyToggleMediator) {
        _IsInputActive = false;
        _StatePlayer = playerState;
        _SprintToggleMediator = sprintProxyToggleMediator;
        _CommandCrouch = new CrouchCommand();
    }

    public ICommandToggle GetCommand() { return _CommandCrouch; }

    public void CheckActivation() {
        if (_IsInputActive) { //Check to see if proxy can become active
            ActiveProxy(); //Proxy is acitve
            _SprintToggleMediator.CancelSprintToggle(); //Send a messages to the sprint proxy informing it that it has been decactivated by the crouch proxy
        } else {
            DeactivateProxy(); //Proxy is inactive 
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
        _IsInputActive = false;
        RetractRequest(); //Cancel this state's impact on the current active state
        _StatePlayer.RemoveInactiveProxy(this); //Remove this proxy from the list of active proxy in PlayerState
    }

    public void SendRequest() {
        _StatePlayer.CurrentPlayerState().Crouch(); //Send state change request to the current active state
    }

    public void RetractRequest() {
        _StatePlayer.CurrentPlayerState().CancelCrouch(); //Retract state change request to the current active state
    }

    public void ProxyCancelToggle() {
        _IsInputActive = false;
        _StatePlayer.RemoveInactiveProxy(this); //Remove this proxy from the list of active proxy in PlayerState
        _CommandCrouch.ExecuteCommand();
        RetractRequest(); //Cancel this state's impact on the current active state
    }
}
