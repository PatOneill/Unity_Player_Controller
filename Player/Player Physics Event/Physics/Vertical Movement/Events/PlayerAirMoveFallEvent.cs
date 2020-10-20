using UnityEngine;

public class PlayerAirMoveFallEvent : AHorizontalFall, IPlayerEvent {
    public PlayerAirMoveFallEvent(PlayerPhysics playerPhysics, Rigidbody playerRigidbody, IPhysicsComponent fallComponent) {
        _PhysicsPlayer = playerPhysics;
        _PlayerRigidbody = playerRigidbody;
        _PlayerTransform = playerRigidbody.transform;
        _FallComponent = fallComponent;
    }

    public void ExecuteAnimationEvent() {
        throw new System.NotImplementedException();
    }

    public void ExecutePhysicsEvent() {
        MovePlayer();
    }
}
