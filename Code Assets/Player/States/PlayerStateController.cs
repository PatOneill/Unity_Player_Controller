public class PlayerStateController {
    private AState _CurrentActiveState;
    private Mediator_Proxies _ProxyMediator;
    private PlayerEventController _EventControllerPlayer;
    #region Declaring all states variables
    private State_Idle _IdleState;
    private State_Walk _WalkState;
    private State_Sprint _SprintState;
    private State_Crouch _CrouchState;
    private State_CrouchWalk _CrouchWalkState;
    #region Gets for all states
    public State_Idle GetIdleState() { return _IdleState; }
    public State_Walk GetWalkState() { return _WalkState; }
    public State_Sprint GetSprintState() { return _SprintState; }
    public State_Crouch GetCrouchState() { return _CrouchState; }
    public State_CrouchWalk GetCrouchWalk() { return _CrouchWalkState; }
    #endregion
    #endregion
    #region Declaring all proxies variables 
    private Proxy_Walk _WalkProxy;
    private Proxy_Sprint _SprintProxy;
    private Proxy_Crouch _CrouchProxy;
    #region Gets for all proxies
    public Proxy_Walk GetWalkProxy() { return _WalkProxy; }
    public Proxy_Sprint GetSprintProxy() { return _SprintProxy; }
    public Proxy_Crouch GetCrouchProxy() { return _CrouchProxy; }
    #endregion
    #endregion

    public PlayerStateController(PlayerEventController eventController, PlayerStatsController statsController) {
        _ProxyMediator = new Mediator_Proxies();
        _EventControllerPlayer = eventController;
        InitializeStates();
        InitializeProxy(statsController);
        _ProxyMediator.SetSprintProxy(_SprintProxy);
        _ProxyMediator.SetCrouchProxy(_CrouchProxy);
        _CurrentActiveState = _IdleState; //Whenever the player is initialized for the first time, start them in the idle state
    }

    private void InitializeStates() {
        /**
         * @desc Initialize all the possible player's states that they can enter upon play prefab construction
        */
        _IdleState = new State_Idle(this);
        _WalkState = new State_Walk(this);
        _SprintState = new State_Sprint(this);
        _CrouchState = new State_Crouch(this);
        _CrouchWalkState = new State_CrouchWalk(this);
    }

    private void InitializeProxy(PlayerStatsController statsController) {
        /**
         * @desc Initialize all the player's proxies
        */
        _WalkProxy = new Proxy_Walk(this, _ProxyMediator);
        _SprintProxy = new Proxy_Sprint(this, _ProxyMediator, statsController.GetAgilityStats().GetSprintStat());
        _CrouchProxy = new Proxy_Crouch(this);
    }

    public AState GetActiveState() {
        /**
         * @desc Return the current state to the proxies so they can send state change requested based on the proxies own interal state
        */
        return _CurrentActiveState;
    }

    public void ChangeState(AState newState) {
        /**
         * @desc If a new state is activated, change the current active state to the new state and update notify the physics and animation controllers of the change
         * @parm AState $newState - The new player state
        */
        _CurrentActiveState = newState;
        _CurrentActiveState.ExecuteStateEvent(_EventControllerPlayer); //After a state change has be implemented, request that the event controller to change the active event accordingly
    }
}