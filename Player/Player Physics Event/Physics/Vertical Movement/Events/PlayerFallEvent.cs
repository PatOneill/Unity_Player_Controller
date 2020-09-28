using UnityEngine;

public class PlayerFallEvent : IPlayerEvent {
    private readonly Rigidbody _PlayerRigidbody;
    private readonly Transform _PlayerTransform;
    private readonly PlayerPhysics _PhysicsPlayer;
    private readonly float _MaxFallSpeed;
    private readonly float _FallSpeed;

    public PlayerFallEvent(PlayerPhysics playerPhysics, Rigidbody playerRigidbody) {
        _PhysicsPlayer = playerPhysics;
        _PlayerRigidbody = playerRigidbody;
        _PlayerTransform = playerRigidbody.transform;
        _MaxFallSpeed = -9.8f;
        _FallSpeed = -4.9f;
    }

    public void ExecuteAnimationEvent() {
        throw new System.NotImplementedException();
    }

    public void ExecutePhysicsEvent() {
        Vector3 currentVelocity = _PhysicsPlayer.CurrentVelocity;
        Vector3 currentPosition = _PlayerTransform.position;

        //Calculate displacement 
        currentPosition.y += (currentVelocity.y * Time.deltaTime) + (0.5f * _FallSpeed * Mathf.Pow(Time.deltaTime, 2));

        //Calculate new velocity 
        currentVelocity.y += (_FallSpeed * Time.deltaTime);

        if (currentVelocity.y > _MaxFallSpeed) { _PhysicsPlayer.CurrentVelocity = currentVelocity; } //Prevent the player from fall faster than a specified speed

        _PlayerRigidbody.MovePosition(currentPosition);
    }
}
