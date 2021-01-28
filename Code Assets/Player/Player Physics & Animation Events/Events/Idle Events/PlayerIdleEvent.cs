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

    }
}
