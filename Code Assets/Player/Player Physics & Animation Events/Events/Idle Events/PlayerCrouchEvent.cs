using UnityEngine;

public class PlayerCrouchEvent : IPlayerEvent {
    private readonly PlayerPhysics _PhysicsPlayer;

    public PlayerCrouchEvent(PlayerPhysics playerPhysics) {
        _PhysicsPlayer = playerPhysics;
    }

    public void ExecuteAnimationEvent() {
        return;
    }

    public void ExecutePhysicsEvent() {

    }
}
