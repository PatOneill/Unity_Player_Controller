using UnityEngine;

public class PlayerCrouchWalk : AHorizontal, IPlayerEvent {

    public PlayerCrouchWalk(PlayerPhysics playerPhysics, Rigidbody playerRigidbody) {
        _PhysicsPlayer = playerPhysics;
        _PlayerRigidbody = playerRigidbody;
        _PlayerTransform = playerRigidbody.transform;
        _MaxVelocity = 1.5f;
        _Acceleration = 1.5f;
    }

    public void ExecuteAnimationEvent() {
        throw new System.NotImplementedException();
    }

    public void ExecutePhysicsEvent() {
        Vector3 direction = _PhysicsPlayer.CalculateHorizontalDirectionWalk();
        MovePlayerHorizontally(direction);
    }
}
