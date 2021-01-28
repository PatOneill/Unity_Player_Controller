public class PlayerCrouchJumpEvent : IPlayerEvent {
    private readonly IPlayerJump _VerticalMovement;

    public PlayerCrouchJumpEvent(IPlayerJump verticalMovement) {
        _VerticalMovement = verticalMovement;
    }

    public void ExecuteAnimationEvent() {
        throw new System.NotImplementedException();
    }

    public void ExecutePhysicsEvent() {
        _VerticalMovement.PlayerJumping();
    }
}
