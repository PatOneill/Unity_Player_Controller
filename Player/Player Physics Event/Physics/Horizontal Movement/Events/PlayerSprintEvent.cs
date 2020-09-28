using UnityEngine;

public class PlayerSprintEvent : IPlayerEvent {
    private readonly Rigidbody _PlayerRigidbody;
    private readonly Transform _PlayerTransform;
    private readonly PlayerPhysics _PhysicsPlayer;
    //private readonly float _MaxSprintSpeed;
    private readonly float _SprintSpeed;

    public PlayerSprintEvent(PlayerPhysics playerPhysics, Rigidbody playerRigidbody) {
        _PhysicsPlayer = playerPhysics;
        _PlayerRigidbody = playerRigidbody;
        _PlayerTransform = playerRigidbody.transform;
        //_MaxSprintSpeed = 6.0f;
        _SprintSpeed = 6.0f;
    }

    public void ExecuteAnimationEvent() {
        throw new System.NotImplementedException();
    }

    public void ExecutePhysicsEvent() {
        Vector3 direction = _PhysicsPlayer.CalculateHorizontalDirection();
        Vector3 moveToLocation = (direction * _SprintSpeed * Time.deltaTime) + _PlayerTransform.position;
        if (_PhysicsPlayer.Grounded_HorizontalMoveCheck(moveToLocation)) {
            direction = _PhysicsPlayer.HorizontalDirection;
            moveToLocation = (direction * _SprintSpeed * Time.deltaTime) + _PlayerTransform.position;
            _PlayerRigidbody.MovePosition(moveToLocation);
        } else {
            return;
        }
    }
}
