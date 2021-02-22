public class PlayerEventController {
    private IEvent _CurrentEvent;
    
    #region Player Events
    private Event_Idle _IdleEvent;
    private Event_Walk _WalkEvent;
    private Event_Sprint _SprintEvent;
    #endregion

    public Event_Walk WalkEvent { get => _WalkEvent; }
    public Event_Sprint SprintEvent { get => _SprintEvent; }

    public PlayerEventController(PlayerStatsController statsController, PlayerPhysicsController physicsController) {
        InitializeEvents(statsController, physicsController);
        _CurrentEvent = _IdleEvent;
    }

    public void InitializeEvents(PlayerStatsController statsController, PlayerPhysicsController physicsController) {
        /**
         * @desc Initialize all the possible player events
        */
        _IdleEvent = new Event_Idle(physicsController);
        _WalkEvent = new Event_Walk(statsController, physicsController);
        _SprintEvent = new Event_Sprint(statsController, physicsController);
    }

    public void ExecuteCurrentEvent() {
        /**
         * @desc Executes the current event's functionality
        */
        _CurrentEvent.ExecuteEvent();
    }

    #region Event Transitions
    public void TransitionToIdleEvent() {
        _CurrentEvent = _IdleEvent;
    }

    public void TransitionToWalkEvent() {
        _CurrentEvent = _WalkEvent;
    }

    public void TransitionToSprintEvent() {
        _CurrentEvent = _SprintEvent;
    }
    #endregion
}
