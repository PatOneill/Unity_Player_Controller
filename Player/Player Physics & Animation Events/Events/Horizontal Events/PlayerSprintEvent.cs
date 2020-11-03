public class PlayerSprintEvent : IPlayerEvent {
    private readonly IHorizontalSprint _HorizontalSprint;
    private readonly float _Acceleration;

    public PlayerSprintEvent(IHorizontalSprint horizontalSprint) {
        _HorizontalSprint = horizontalSprint;
        _Acceleration = 6.0f;
    }

    public void ExecuteAnimationEvent() {
        throw new System.NotImplementedException();
    }

    public void ExecutePhysicsEvent() {
        _HorizontalSprint.PlayerSprintHorizontally(in _Acceleration);
    }
}
