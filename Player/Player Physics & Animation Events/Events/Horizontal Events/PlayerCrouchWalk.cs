public class PlayerCrouchWalk : IPlayerEvent {
    private readonly IHorizontalMove _HorizontalMove;
    private readonly float _Acceleration;

    public PlayerCrouchWalk(IHorizontalMove horizontalMove) {
        _HorizontalMove = horizontalMove;
        _Acceleration = 1.5f;
    }

    public void ExecuteAnimationEvent() {
        throw new System.NotImplementedException();
    }

    public void ExecutePhysicsEvent() {
        _HorizontalMove.PlayerMoveHorizontally(in _Acceleration);
    }
}
