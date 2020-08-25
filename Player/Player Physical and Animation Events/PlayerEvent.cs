using UnityEngine;

public class PlayerEvent {
    private IPlayerEvent _CurrentEvent;

    private IdleEvent _PlayerIdleEvent;
    private WalkEvent _PlayerWalkEvent;
    private SprintEvent _PlayerSprintEvent;
    private AirMoveEvent _PlayerAirMoveEvent;
    private FallEvent _PlayerFallEvent;

    private HorizontalMovement _MovementHorizontal;

    public IPlayerEvent CurrentEvent { get => _CurrentEvent; }
    #region Get methods for Events that observe changes in other classes
    public WalkEvent PlayerWalkEvent { get => _PlayerWalkEvent; }
    public SprintEvent PlayerSprintEvent { get => _PlayerSprintEvent; }
    public AirMoveEvent PlayerAirMoveEvent { get => _PlayerAirMoveEvent; }
    #endregion

    public PlayerEvent(Rigidbody playerRigidbody) {
        _MovementHorizontal = new HorizontalMovement(playerRigidbody);

        _PlayerIdleEvent = new IdleEvent(playerRigidbody);
        _PlayerWalkEvent = new WalkEvent(_MovementHorizontal);
        _PlayerSprintEvent = new SprintEvent(_MovementHorizontal);
        _PlayerAirMoveEvent = new AirMoveEvent(_MovementHorizontal);
        _PlayerFallEvent = new FallEvent(playerRigidbody);

        _CurrentEvent = _PlayerIdleEvent;
    }

    public void IdleEvent() {
        _CurrentEvent = _PlayerIdleEvent;
    }

    public void WalkEvent() {
        _CurrentEvent = _PlayerWalkEvent;
    }

    public void SprintEvent() {
        _CurrentEvent = _PlayerSprintEvent;
    }

    public void FallEvent() {
        _CurrentEvent = _PlayerFallEvent;
    }

    public void AirMoveEvent() {
        _CurrentEvent = _PlayerAirMoveEvent;
    }
}
