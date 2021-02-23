using UnityEngine;

public class PlayerPhysicsController : IInputObserver {
    private Rigidbody _PlayerRigidbody;
    private Transform _PlayerRigidbodyTransform;
    private Vector3 _PlayerMoveDirection;

    public PlayerPhysicsController(Rigidbody playerRigidbody) {
        _PlayerRigidbody = playerRigidbody;
        _PlayerRigidbodyTransform = playerRigidbody.transform;
        _PlayerMoveDirection = Vector3.zero;
    }

    public void FullyStopMotion() {
        /**
         * @desc Instantly cancel out the player's velocity in all directions forcing the rigidbody to come to a complete stop in a single frame
        */
        return;
    }

    public void MovePlayer(float acceleration) {
        /**
         * @desc Checks for collision events, changes movement values according to the collision events (if any found), and moves the player's rigidbody's position according to the current active event
         * @parm Vector3 $accelerationDirection - A vector that represents the direction the player wishes to move towards, and that has already been multiplied by the scaler of the acceleration (Note: acceleration amount depends on the player's current active event)
        */
        Vector3 accelerationDirection = _PlayerMoveDirection * acceleration;
        Vector3 movePosition = ((accelerationDirection.x * _PlayerRigidbodyTransform.right) + (accelerationDirection.z * _PlayerRigidbodyTransform.forward)) * Time.deltaTime; //Calculate the position the player wants to move to
        //Check for collision events here
        //Solve collision events here
        _PlayerRigidbody.MovePosition(movePosition + _PlayerRigidbodyTransform.position); //Move the player's kinematic rigidbody
    }

    public void Update(Vector2 direction) {
        /**
         * @desc Get the direction the player wants to move towards from the player's input controller (Note: This method is only called while the inputs assigned to the move action have their values altered)
         * @parm Vector2 $direction - Holds the direction the player wishes to move towards
        */
        _PlayerMoveDirection = new Vector3(direction.x, 0.0f, direction.y);
    }
}
