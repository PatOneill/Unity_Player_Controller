public class PlayerJumpEvent : IPlayerEvent {
    private readonly IPlayerJump _VerticalMovement;

    public PlayerJumpEvent(IPlayerJump verticalMovement) {
        _VerticalMovement = verticalMovement;
    }

    public void ExecuteAnimationEvent() {
        throw new System.NotImplementedException();
    }

    public void ExecutePhysicsEvent() {
        _VerticalMovement.PlayerJumping();
    }
}
