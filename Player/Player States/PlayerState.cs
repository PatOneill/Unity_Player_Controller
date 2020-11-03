using System.Collections.Generic;

public class PlayerState : IStateProxyInput, IStateProxy, IState {
    private APlayerState _CurrentPlayerState;
    private ToggleProxyMediator _MediatorToggleProxy;
    private PhysicsProxyMediator _MediatorPhysicsProxy;
    private HashSet<IDynamicProxy> _ActiveProxies;
    private readonly IEventManager _EventPlayer;

    #region Proxies
    private readonly WalkProxy _ProxyWalk;
    private readonly SprintProxy _ProxySprint;
    private readonly FallProxy _ProxyFall;
    private readonly CrouchProxy _ProxyCrouch;
    private readonly JumpProxy _ProxyJump;
    #endregion
    #region Get methods for state proxies
    public IInputProxyToggle ProxyCrouch() { return _ProxyCrouch; }
    public IInputProxyToggle ProxySprint() { return _ProxySprint; }
    public IStateProxyOnOff ProxyWalk() { return _ProxyWalk; }
    public IStateProxyOnOff ProxyFall() { return _ProxyFall; }
    public IStateProxyOn ProxyJump() { return _ProxyJump; }
    public IStateProxyOff ProxyJumpPhysics() { return _ProxyJump; }

    public IAnalogInputObserver ProxySprintObserver() { return _ProxySprint; }
    #endregion

    #region States
    private readonly IdleState _StateIdle;
    private readonly WalkState _StateWalk;
    private readonly SprintState _StateSprint;
    private readonly FallState _StateFall;
    private readonly CrouchState _StateCrouch;
    private readonly JumpState _StateJump;
    private readonly CrouchWalkState _StateCrouchWalk;
    private readonly SlideState _StateSlide;
    private readonly CrouchJumpState _StateCrouchJump;
    private readonly CrouchFallState _StateCrouchFall;
    private readonly AirMoveCrouchFallState _StateAirMoveCrouchFall;
    private readonly AirMoveCrouchJumpState _StateAirMoveCrouchJump;
    private readonly AirMoveFallState _StateAirMoveFall;
    private readonly AirMoveJumpState _StateAirMoveJump;
    #endregion
    #region Get methods for states
    public IdleState StateIdle() { return _StateIdle; }
    public WalkState StateWalk() { return _StateWalk; }
    public SprintState StateSprint() { return _StateSprint; }
    public FallState StateFall() { return _StateFall; }
    public CrouchWalkState StateCrouchWalk() { return _StateCrouchWalk; }
    public CrouchState StateCrouch() { return _StateCrouch; }
    public JumpState StateJump() { return _StateJump; }
    public SlideState StateSlide() { return _StateSlide; }
    public CrouchJumpState StateCrouchJump() { return _StateCrouchJump; }
    public CrouchFallState StateCrouchFall() { return _StateCrouchFall; }
    public AirMoveCrouchFallState StateAirMoveCrouchFall()  { return _StateAirMoveCrouchFall; }
    public AirMoveCrouchJumpState StateAirMoveCrouchJump() {return _StateAirMoveCrouchJump; }
    public AirMoveFallState StateAirMoveFall() { return _StateAirMoveFall; }
    public AirMoveJumpState StateAirMoveJump() { return _StateAirMoveJump; }
    #endregion

    public PlayerState(IEventManager playerEvent) {
        #region Player State Initialization
        _StateIdle = new IdleState(this);
        _StateWalk = new WalkState(this);
        _StateSprint = new SprintState(this);
        _StateFall = new FallState(this);
        _StateCrouch = new CrouchState(this);
        _StateJump = new JumpState(this);
        _StateCrouchWalk = new CrouchWalkState(this);
        _StateSlide = new SlideState(this);
        _StateCrouchJump = new CrouchJumpState(this);
        _StateCrouchFall = new CrouchFallState(this);
        _StateAirMoveCrouchFall = new AirMoveCrouchFallState(this);
        _StateAirMoveCrouchJump = new AirMoveCrouchJumpState(this);
        _StateAirMoveFall = new AirMoveFallState(this);
        _StateAirMoveJump = new AirMoveJumpState(this);
        #endregion

        _ActiveProxies = new HashSet<IDynamicProxy>();
        _EventPlayer = playerEvent;
        _CurrentPlayerState = _StateIdle;

        #region State Proxy Initialization
        _MediatorToggleProxy = new ToggleProxyMediator();
        _MediatorPhysicsProxy = new PhysicsProxyMediator();
        _ProxySprint = new SprintProxy(this, _MediatorToggleProxy);
        _ProxyCrouch = new CrouchProxy(this, _MediatorToggleProxy);
        _MediatorToggleProxy.ProxyCrouch = _ProxyCrouch;
        _MediatorToggleProxy.ProxySprint = _ProxySprint;

        _ProxyWalk = new WalkProxy(this, _MediatorToggleProxy);
        _ProxyFall = new FallProxy(this, _MediatorPhysicsProxy);
        _ProxyJump = new JumpProxy(this, _MediatorToggleProxy);
        _MediatorPhysicsProxy.ProxyJump = _ProxyJump;
        #endregion
    }

    public APlayerState CurrentPlayerState() {
        return _CurrentPlayerState;
    }

    public void AddActiveProxy(IDynamicProxy activeProxy) {
        _ActiveProxies.Add(activeProxy);
        CheckActiveProxy();
    }

    public void RemoveInactiveProxy(IDynamicProxy inactiveProxy) {
        _ActiveProxies.Remove(inactiveProxy);
        CheckActiveProxy();
    }

    private void CheckActiveProxy() {
        foreach (IDynamicProxy proxy in _ActiveProxies) {
            proxy.SendRequest();
        }
    }

    public void ChangeState(APlayerState newState) {
        _CurrentPlayerState = newState;
        _CurrentPlayerState.ExecuteStateEvent(_EventPlayer);
    }
}
