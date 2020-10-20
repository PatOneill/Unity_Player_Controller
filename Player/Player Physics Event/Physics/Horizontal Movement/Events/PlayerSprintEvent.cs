using UnityEngine;

public class PlayerSprintEvent : AHorizontal, IPlayerEvent {

    public PlayerSprintEvent(PlayerPhysics playerPhysics, Rigidbody playerRigidbody) {
        _PhysicsPlayer = playerPhysics;
        _PlayerRigidbody = playerRigidbody;
        _PlayerTransform = playerRigidbody.transform;
        _MaxVelocity = 6.0f;
        _Acceleration = 6.0f;
    }

    public void ExecuteAnimationEvent() {
        throw new System.NotImplementedException();
    }

    public void ExecutePhysicsEvent() {
        Vector3 direction = _PhysicsPlayer.CalculateHorizontalDirectionSprint();
        MovePlayerHorizontally(direction);
    }
}
