using UnityEngine;

public abstract class AHorizontal {
    protected Rigidbody _PlayerRigidbody;
    protected Transform _PlayerTransform;
    protected PlayerPhysics _PhysicsPlayer;
    private float _DecelerateTime = 0.2f;
    protected float _MaxVelocity;
    protected float _Acceleration;

    public void MovePlayerHorizontally(Vector3 direction) {
        float speed = _Acceleration;
        if (_PhysicsPlayer.CurrentVelocity.x > _MaxVelocity) { //Begin to decay the speed at which the player is moving if their current speed is greater than a set speed set in each event
            Vector2 newVelocity = _PhysicsPlayer.CurrentVelocity;
            newVelocity.x = Mathf.Lerp(newVelocity.x, _MaxVelocity, _DecelerateTime);
            speed = newVelocity.x;
            _PhysicsPlayer.CurrentVelocity = newVelocity;
        }
        direction = (direction * speed * Time.deltaTime) + _PlayerTransform.position;
        _PhysicsPlayer.HorizontalMoveCheck(direction);
        direction = _PhysicsPlayer.HorizontalDirection();
        direction = (direction * speed * Time.deltaTime) + _PlayerTransform.position;
        _PlayerRigidbody.MovePosition(direction);


        //Store the horizontal player speed
        Vector2 temp = _PhysicsPlayer.CurrentVelocity;
        temp.x = _PlayerRigidbody.velocity.magnitude;
        _PhysicsPlayer.CurrentVelocity = temp;
    }
}
