using UnityEngine;

public class PlayerHorizontalMovement : IHorizontalMove, IHorizontalSprint, IHorizontalDisplacement {
    private PlayerPhysics _PhysicsPlayer;
    private Rigidbody _PlayerRigidbody;
    private Transform _PlayerTransform;
    private readonly float _DecelerateOverTime;

    public PlayerHorizontalMovement(PlayerPhysics playerPhysics, Rigidbody playerRigidbody) {
        _PhysicsPlayer = playerPhysics;
        _PlayerRigidbody = playerRigidbody;
        _PlayerTransform = playerRigidbody.transform;

        _DecelerateOverTime = 0.05f;
    }

    public void PlayerMoveHorizontally(in float acceleration) {
        Vector3 direction = _PhysicsPlayer.CalculateHorizontalDirection(); //Calculate the direction the player wants to move towards while walking or crouch walking

        MoveDedecelerate(acceleration);
        HorizontalMovementDisplacement(ref direction);

        _PhysicsPlayer.HorizontalMoveCheck(direction); //Check horizontal move location to ensure player will not collid with anything. NOTE: This function might change the horizontal direction
        
        direction = _PhysicsPlayer.HorizontalDirection; //Get new direction after physics system has had a change to respond to the move request
        HorizontalMovementDisplacement(ref direction);

        _PlayerRigidbody.MovePosition(direction);
    }

    public void PlayerSprintHorizontally(in float acceleration) {
        Vector3 direction = _PhysicsPlayer.CalculateHorizontalDirection().normalized; //Calculate the direction the player wants to move towards while sprinting

        SprintDedecelerate(acceleration);
        HorizontalMovementDisplacement(ref direction);
        
        _PhysicsPlayer.HorizontalMoveCheck(direction); //Check horizontal move location to ensure player will not collid with anything. NOTE: This function might change the horizontal direction
        
        direction = _PhysicsPlayer.HorizontalDirection.normalized; //Get new direction after physics system has had a change to respond to the move request
        HorizontalMovementDisplacement(ref direction);

        _PlayerRigidbody.MovePosition(direction);
    }

    public void HorizontalMovementDisplacement(ref Vector3 direction) {
        direction = (direction * _PhysicsPlayer.CurrentVelocity.x * Time.deltaTime) + _PlayerTransform.position;
    }

    #region Private Functions
    private void MoveDedecelerate(in float acceleration) {
        Vector2 newVelocity = _PhysicsPlayer.CurrentVelocity;

        if (newVelocity.x > acceleration) { //If the player's current speed exceeds the max speed allowed for a given state, begin to decay the current speed over time NOTE: Acceleration also doubles as max speed
            newVelocity.x = Mathf.Lerp(newVelocity.x, acceleration, _DecelerateOverTime);
            _PhysicsPlayer.CurrentVelocity = newVelocity;
        } else {
            HorizontalVelocityIncrease(in acceleration); //Store the horizontal speed for the player 
        }
    }

    private void SprintDedecelerate(in float acceleration) {
        Vector2 newVelocity = _PhysicsPlayer.CurrentVelocity;

        if (newVelocity.x > acceleration) { //If the player's current speed exceeds the max speed allowed for a given state, begin to decay the current speed over time NOTE: Acceleration also doubles as max speed
            newVelocity.x = Mathf.Lerp(newVelocity.x, acceleration, _DecelerateOverTime);
            _PhysicsPlayer.CurrentVelocity = newVelocity;
        } else {
            HorizontalVelocitySprint(in acceleration); //Set the horizontal speed for the player to max 
        }
    }

    private void HorizontalVelocityIncrease(in float acceleration) {
        Vector3 direction = _PhysicsPlayer.CalculateHorizontalDirection();
        Vector2 currentVelocity = _PhysicsPlayer.CurrentVelocity;
        currentVelocity.x = (acceleration * direction).magnitude; //Calculate new horizontal velocity 
        _PhysicsPlayer.CurrentVelocity = currentVelocity;
    }
    
    private void HorizontalVelocitySprint(in float acceleration) {
        Vector2 currentVelocity = _PhysicsPlayer.CurrentVelocity;
        currentVelocity.x = acceleration;
        _PhysicsPlayer.CurrentVelocity = currentVelocity;
    }
    #endregion
}
