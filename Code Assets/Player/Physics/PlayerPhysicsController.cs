using UnityEngine;

public class PlayerPhysicsController {
    private Rigidbody _PlayerRigidbody;
    private Transform _PlayerRigidbodyTransform;

    public PlayerPhysicsController(Rigidbody playerRigidbody) {
        _PlayerRigidbody = playerRigidbody;
        _PlayerRigidbodyTransform = playerRigidbody.transform;
    }

    public void FullyStopMotion() {
        /**
         * @desc Instantly cancel out the player's velocity in all directions forcing the rigidbody to come to a complete stop in a single frame
        */
        
    }

    public void MovePlayer(Vector3 accelerationDirection) {
        /**
         * @desc Checks for collision events, changes movement values according to the collision events (if any found), and moves the player's rigidbody's position according to the current active event
         * @parm Vector3 $accelerationDirection - A vector that represents the direction the player wishes to move towards, and that has already been multiplied by the scaler of the acceleration (Note: acceleration amount depends on the player's current active event)
        */
        Vector3 movePosition = ((accelerationDirection.x * _PlayerRigidbodyTransform.right) + (accelerationDirection.z * _PlayerRigidbodyTransform.forward)) * Time.deltaTime;
    }
}
