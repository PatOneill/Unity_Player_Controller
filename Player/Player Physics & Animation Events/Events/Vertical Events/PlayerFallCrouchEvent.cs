public class PlayerFallCrouchEvent : IPlayerEvent {
    private readonly IPlayerFall _VerticalMovement;

    public PlayerFallCrouchEvent(IPlayerFall verticalMovement) {
        _VerticalMovement = verticalMovement;
    }

    public void ExecuteAnimationEvent() {
        throw new System.NotImplementedException();
    }

    public void ExecutePhysicsEvent() {
        _VerticalMovement.PlayerFalling();
    }
}
