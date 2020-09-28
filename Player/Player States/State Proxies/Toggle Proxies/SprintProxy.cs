using UnityEngine;

public class SprintProxy : IInputProxyToggle, IDynamicProxy, IAnalogInputObserver {
    private readonly IStateProxy _StatePlayer;
    private readonly IToggleProxyCrouchMediator _CrouchToggleMediator;
    private bool _IsInputActive;
    private SprintCommand _CommandSprint;
    private Vector3 _WalkInput;

    public SprintProxy(IStateProxy playerState, IToggleProxyCrouchMediator crouchProxyToggleMediator) {
        _IsInputActive = false;
        _StatePlayer = playerState;
        _CommandSprint = new SprintCommand();
        _CrouchToggleMediator = crouchProxyToggleMediator;
        _WalkInput = Vector3.zero;
    }

    public ICommandToggle GetCommand() { return _CommandSprint; }

    public void CheckActivation() {
        if (_IsInputActive) { //Check to see if proxy can become active
            ActiveProxy(); //Proxy is acitve
            _CrouchToggleMediator.CancelCrouchToggle(); //Send a messages to the crouch proxy informing it that it has been decactivated by the sprint proxy
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
        _StatePlayer.RemoveInactiveProxy(this); //Remove this proxy from the list of active proxy in PlayerState
        _IsInputActive = false;
        RetractRequest(); //Cancel this state's impact on the current active state
    }

    public void SendRequest() {
        _StatePlayer.CurrentPlayerState().Sprint(); //Send state change request to the current active state
    }

    public void RetractRequest() {
        _StatePlayer.CurrentPlayerState().CancelSprint(); //Retract state change request to the current active state
    }

    public void Update(Vector2 direction) {
        _WalkInput = direction; //Keep track of how the player is moving their analog stick for walk event
        DirectionCheck();
    }

    public void ProxyCancelToggle() {
        _IsInputActive = false;
        _StatePlayer.RemoveInactiveProxy(this); //Remove this proxy from the list of active proxy in PlayerState
        _CommandSprint.ExecuteCommand();
        RetractRequest(); //Cancel this state's impact on the current active state
    }

    private void DirectionCheck() {
        
    }
}
