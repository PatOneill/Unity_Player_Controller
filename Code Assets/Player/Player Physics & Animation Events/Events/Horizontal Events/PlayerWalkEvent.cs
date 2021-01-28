public class PlayerWalkEvent : IPlayerEvent {
    private readonly IHorizontalMove _HorizontalMove;
    private readonly float _Acceleration;
    private readonly float _MaxVelocity;

    public PlayerWalkEvent(IHorizontalMove horizontalMove) {
        _HorizontalMove = horizontalMove;
        _Acceleration = 10.0f;
        _MaxVelocity = 3.0f;
    }

    public void ExecuteAnimationEvent() {
        throw new System.NotImplementedException();
    }

    public void ExecutePhysicsEvent() {
        _HorizontalMove.PlayerMoveHorizontally(in _Acceleration, in _MaxVelocity);
    }
}
