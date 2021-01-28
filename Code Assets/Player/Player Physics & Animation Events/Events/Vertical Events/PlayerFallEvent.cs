public class PlayerFallEvent : IPlayerEvent {
    private readonly IPlayerFall _VerticalMovement;

    public PlayerFallEvent(IPlayerFall verticalMovement) {
        _VerticalMovement = verticalMovement;
    }

    public void ExecuteAnimationEvent() {
        throw new System.NotImplementedException();
    }

    public void ExecutePhysicsEvent() {
        _VerticalMovement.PlayerFalling();
    }
}
