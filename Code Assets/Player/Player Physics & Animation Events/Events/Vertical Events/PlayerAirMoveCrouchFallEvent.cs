public class PlayerAirMoveCrouchFallEvent : IPlayerEvent {
    private readonly IPlayerHorizontalFall _VerticalMovement;

    public PlayerAirMoveCrouchFallEvent(IPlayerHorizontalFall verticalMovement) {
        _VerticalMovement = verticalMovement;
    }

    public void ExecuteAnimationEvent() {
        throw new System.NotImplementedException();
    }

    public void ExecutePhysicsEvent() {
        _VerticalMovement.PlayerHorizontalFalling();
    }
}
