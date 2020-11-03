public class PlayerAirMoveFallEvent : IPlayerEvent {
    private readonly IPlayerHorizontalFall _VerticalMovement;
    public PlayerAirMoveFallEvent(IPlayerHorizontalFall verticalMovement) {
        _VerticalMovement = verticalMovement;
    }

    public void ExecuteAnimationEvent() {
        throw new System.NotImplementedException();
    }

    public void ExecutePhysicsEvent() {
        _VerticalMovement.PlayerHorizontalFalling();
    }
}
