using UnityEngine;

public class PlayerIdleEvent : IPlayerEvent {
    private readonly PlayerPhysics _PhysicsPlayer;

    public PlayerIdleEvent(PlayerPhysics playerPhysics) {
        _PhysicsPlayer = playerPhysics;
    }

    public void ExecuteAnimationEvent() {
        return;
    }

    public void ExecutePhysicsEvent() {
        Vector2 currentVelocity = _PhysicsPlayer.CurrentVelocity;
        currentVelocity.x = 0.0f;
        _PhysicsPlayer.CurrentVelocity = currentVelocity;
        _PhysicsPlayer.AttractToGround();
    }
}
