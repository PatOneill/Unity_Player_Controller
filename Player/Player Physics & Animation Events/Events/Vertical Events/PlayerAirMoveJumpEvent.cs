public class PlayerAirMoveJumpEvent : IPlayerEvent {
    private readonly IPlayerHorizontalJump _VerticalMovement;

    public PlayerAirMoveJumpEvent(IPlayerHorizontalJump verticalMovement) {
        _VerticalMovement = verticalMovement;
    }

    public void ExecuteAnimationEvent() {
        throw new System.NotImplementedException();
    }

    public void ExecutePhysicsEvent() {
        _VerticalMovement.PlayerHorizontalJumping();
    }
}
