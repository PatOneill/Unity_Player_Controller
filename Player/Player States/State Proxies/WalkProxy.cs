public class WalkProxy : IDynamicProxy, IStateProxy {
    private readonly PlayerState _StatePlayer;
    private readonly ToggleMediator _MediatorToggle;

    public WalkProxy(PlayerState playerState, ToggleMediator toggleMediator) {
        _StatePlayer = playerState;
        _MediatorToggle = toggleMediator;
    }

    public void ActiveProxy() {
        _StatePlayer.AddActiveProxy(this);
    }

    public void DeactivateProxy() {
        _MediatorToggle.KillSprintToggle(); //If the move input is canceled, call upon the toggle mediator tell sprint proxy to pass a message to set sprint's input toggle to be set false 
        _StatePlayer.RemoveInactiveProxy(this);
        RetractRequest();
    }

    public void SendRequest() {
        _StatePlayer.Walk();
    }

    public void RetractRequest() {
        _StatePlayer.CancelWalk();
    }
}
