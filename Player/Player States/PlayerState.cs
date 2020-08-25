using System.Collections.Generic;
using UnityEngine;

public class PlayerState {
    private APlayerState _CurrentPlayerState;
    private HashSet<IStateProxy> _ActiveProxies;
    private readonly ToggleMediator _MediatorToggle;
    private bool _StateUpdate;
    public APlayerState CurrentPlayerState { get => _CurrentPlayerState; }

    #region Proxies
    private readonly WalkProxy _ProxyWalk;
    private readonly SprintProxy _ProxySprint;
    private readonly LookProxy _ProxyLook;
    private readonly FallProxy _ProxyFall;
    #endregion
    #region Get methods for state proxies
    public WalkProxy ProxyWalk { get => _ProxyWalk; }
    public SprintProxy ProxySprint { get => _ProxySprint; }
    public LookProxy ProxyLook { get => _ProxyLook; }
    public FallProxy ProxyFall { get => _ProxyFall; }
    #endregion

    #region States
    private readonly IdleState _StateIdle;
    private readonly WalkState _StateWalk;
    private readonly SprintState _StateSprint;
    private readonly FallState _StateFall;
    private readonly AirMoveState _StateAirMove;
    #endregion
    #region Get methods for states
    public IdleState StateIdle { get => _StateIdle; }
    public WalkState StateWalk { get => _StateWalk; }
    public SprintState StateSprint { get => _StateSprint; }
    public FallState StateFall { get => _StateFall; }
    public AirMoveState StateAirMove { get => _StateAirMove; }
    #endregion
    
    public PlayerState(PlayerCamera playerCamera ) {
        _ActiveProxies = new HashSet<IStateProxy>();
        _StateIdle = new IdleState(this);
        _StateWalk = new WalkState(this);
        _StateSprint = new SprintState(this);
        _StateFall = new FallState(this);
        _StateAirMove = new AirMoveState(this);

        _CurrentPlayerState = _StateIdle;
        _ProxySprint = new SprintProxy(this);
        _MediatorToggle = new ToggleMediator(_ProxySprint);
        _ProxyWalk = new WalkProxy(this, _MediatorToggle);
        _ProxyLook = new LookProxy(playerCamera);
        _ProxyFall = new FallProxy(this);

        _StateUpdate = true;
    }

    public void AddActiveProxy(IStateProxy activeProxy) {
        _StateUpdate = true;
        _ActiveProxies.Add(activeProxy);
    }

    public void RemoveInactiveProxy(IStateProxy inactiveProxy) {
        _StateUpdate = true;
        _ActiveProxies.Remove(inactiveProxy);
    }

    public void CheckActiveProxy() {
        if(!_StateUpdate) { return; } //Only enter loop if a state was removed or added recently
        _StateUpdate = false;
        foreach (IStateProxy proxy in _ActiveProxies) {
            proxy.SendRequest();
        }
    }

    public void ChangeState(APlayerState newState) {
        _CurrentPlayerState = newState;
    }

    public void Walk() {
        _CurrentPlayerState.Walk();
    }

    public void CancelWalk() {
        _CurrentPlayerState.CancleWalk();
    }

    public void Sprint() {
        _CurrentPlayerState.Sprint();
    }

    public void CancelSprint() {
        _CurrentPlayerState.CancelSprint();
    }

    public void Fall() {
        _CurrentPlayerState.Fall();
    }

    public void CancelFall() {
        _CurrentPlayerState.CancelFall();
    }
}
