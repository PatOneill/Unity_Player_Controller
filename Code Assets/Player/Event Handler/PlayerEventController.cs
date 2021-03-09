public class PlayerEventController {
    private IEvent _CurrentEvent;
    
    #region Player Events
    private Event_Idle _IdleEvent;
    private Event_Walk _WalkEvent;
    private Event_Sprint _SprintEvent;
    private Event_Crouch _CrouchEvent;
    private Event_CrouchWalk _CrouchWalkeEvent;
    #region Get methods for player events
    public Event_Idle GetIdleEvent() { return _IdleEvent; }
    public Event_Walk GetWalkEvent() { return _WalkEvent; }
    public Event_Sprint GetSprintEvent() { return _SprintEvent; }
    public Event_Crouch GetCrouchEvent() { return _CrouchEvent; }
    public Event_CrouchWalk GetCrouchWalkEvent() { return _CrouchWalkeEvent; }
    #endregion
    #endregion

    public PlayerEventController(PlayerStatsController statsController, PlayerPhysicsController physicsController, PlayerAnimationController animationController) {
        InitializeEvents(statsController, physicsController, animationController);
        _CurrentEvent = _IdleEvent;
        _CurrentEvent.CurrentEventAnimationStart(); //Start playing the starting animation once the player has fully load into the level
    }

    public void InitializeEvents(PlayerStatsController statsController, PlayerPhysicsController physicsController, PlayerAnimationController animationController) {
        /**
         * @desc Initialize all the possible player events
        */
        _IdleEvent = new Event_Idle(physicsController, animationController);
        _WalkEvent = new Event_Walk(statsController, physicsController, animationController);
        _SprintEvent = new Event_Sprint(statsController, physicsController, animationController);
        _CrouchEvent = new Event_Crouch(physicsController, animationController);
        _CrouchWalkeEvent = new Event_CrouchWalk(statsController, physicsController, animationController);
    }

    public void ExecuteCurrentEvent() {
        /**
         * @desc Executes the current event's physics functionality
        */
        _CurrentEvent.CurrentEventPhysics();
    }

    public void TransitionToNewEvent(IEvent newEvent) {
        /**
         * @desc Change the player's current to a new event
        */
        _CurrentEvent.CurrentEventAnimationStop(); //Inform the old event that its animation must enter an exit state (NOTE: time to exit the old event's animation depends on the exit case for the animation and crossfade time)
        _CurrentEvent = newEvent;
        _CurrentEvent.CurrentEventAnimationStart(); //Inform the new event that its can start its animation state
    }
}
