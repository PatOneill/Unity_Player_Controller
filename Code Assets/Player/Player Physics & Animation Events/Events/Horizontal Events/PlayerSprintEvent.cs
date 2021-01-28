public class PlayerSprintEvent : IPlayerEvent {
    private readonly IHorizontalMove _HorizontalSprint;
    private readonly float _Acceleration;
    private readonly float _MaxVelocity;

    public PlayerSprintEvent(IHorizontalMove horizontalSprint) {
        _HorizontalSprint = horizontalSprint;
        _Acceleration = 20.0f; ;
        _MaxVelocity = 6.0f;
    }

    public void ExecuteAnimationEvent() {
        throw new System.NotImplementedException();
    }

    public void ExecutePhysicsEvent() {
        _HorizontalSprint.PlayerMoveHorizontally(in _Acceleration, in _MaxVelocity);
    }
}
