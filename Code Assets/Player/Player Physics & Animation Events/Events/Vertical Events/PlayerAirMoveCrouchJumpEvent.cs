public class PlayerAirMoveCrouchJumpEvent : IPlayerEvent {
    private readonly IPlayerHorizontalJump _VerticalMovement;

    public PlayerAirMoveCrouchJumpEvent(IPlayerHorizontalJump verticalMovement) {
        _VerticalMovement = verticalMovement;
    }

    public void ExecuteAnimationEvent() {
        throw new System.NotImplementedException();
    }

    public void ExecutePhysicsEvent() {
        _VerticalMovement.PlayerHorizontalJumping();
    }
}
