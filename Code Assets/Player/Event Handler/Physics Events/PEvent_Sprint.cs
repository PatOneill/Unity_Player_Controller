using UnityEngine;

public class PEvent_Sprint : IInputObserver {
    private PlayerPhysicsController _PhysicsControllerPlayer;
    private Vector3 _PlayerMoveDirection;
    public PEvent_Sprint(PlayerPhysicsController playerPhysicsController) {
        _PhysicsControllerPlayer = playerPhysicsController;
        _PlayerMoveDirection = Vector3.zero;
    }

    public void ExecutePhysicsEvent(float sprintAcceleration) {
        /**
         * @desc Takes the player's rigidbody and applys the sprinting physics event causing the player's rigidbody to move horizontally
         * @parm float $sprintAcceleration - The speed at which the player will accelerate
        */
        Vector3 moveDirection = _PlayerMoveDirection * sprintAcceleration;
        _PhysicsControllerPlayer.MovePlayer(_PlayerMoveDirection);
    }

    public void Update(Vector2 direction) {
        /**
         * @desc Get the direction the player wants to move towards from the player's input controller (Note: This method is only called while the inputs assigned to the move action have their values altered)
         * @parm Vector2 $direction - Holds the direction the player wishes to move towards
        */
        _PlayerMoveDirection = new Vector3(direction.x, 0.0f, direction.y).normalized;
    }
}
