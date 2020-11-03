using UnityEngine;

public class PlayerVerticalMovement : IPlayerJump, IPlayerFall, IPlayerHorizontalJump, IPlayerHorizontalFall {
    private PlayerPhysics _PhysicsPlayer;
    private Rigidbody _PlayerRigidbody;
    private Transform _PlayerTransform;
    private readonly IHorizontalDisplacement _HorizontalMovement;
    private readonly IVerticalMovement _CeilingPhysics;
    private readonly float _FallSpeed;
    private readonly float _MaxFallSpeed;
    private readonly float _MidAirReduction;
    private readonly float _MinAirMoveSpeed;
    private readonly float _HorizontalDecayRate;

    public PlayerVerticalMovement(PlayerPhysics playerPhysics, Rigidbody playerRigidbody, IHorizontalDisplacement horizontalMovement) {
        _PhysicsPlayer = playerPhysics;
        _PlayerRigidbody = playerRigidbody;
        _PlayerTransform = playerRigidbody.transform;
        _CeilingPhysics = _PhysicsPlayer.GetCeilingCheck();
        _HorizontalMovement = horizontalMovement;

        _FallSpeed = -4.9f;
        _MaxFallSpeed = -9.8f;
        _MidAirReduction = 4.0f;
        _MinAirMoveSpeed = 0.1f;
        _HorizontalDecayRate = 0.05f;
    }

    //Player is jumping with no horizontal velocity
    public void PlayerJumping() {
        Vector3 currentPosition = JumpCalculation();
        if (_CeilingPhysics.CheckCeiling(currentPosition)) { //Physics check to see if the player has collided with a physics object that will end upwards vertical movtion
            currentPosition = JumpCalculation();
        }
        _PlayerRigidbody.MovePosition(currentPosition);
    }

    //Player is jumping with a horizontal velocity
    public void PlayerHorizontalJumping() {
        //Ensure that if the player moves, they can only move slightly while in mid air
        Vector3 direction = _PhysicsPlayer.HorizontalDirection;
        Vector2 currentVelocity = _PhysicsPlayer.CurrentVelocity;
        AnalogInputAffects(ref direction, ref currentVelocity);

        _HorizontalMovement.HorizontalMovementDisplacement(ref direction);
        float yPlacement = FallCalculation().y;
        direction.y = yPlacement;

        _PhysicsPlayer.AerialHorizontalMoveCheck(direction);

        direction = _PhysicsPlayer.HorizontalDirection + (_PhysicsPlayer.CalculateHorizontalDirectionMidAir() / _MidAirReduction);
        _HorizontalMovement.HorizontalMovementDisplacement(ref direction);
        direction.y = yPlacement;

        _PlayerRigidbody.MovePosition(direction);
    }

    //Player is falling with no horizontal velocity
    public void PlayerFalling() {
        Vector3 currentPosition = FallCalculation();
        _PlayerRigidbody.MovePosition(currentPosition);
        _PhysicsPlayer.AttractToGround();
    }

    //Player is falling with a horizontal velocity
    public void PlayerHorizontalFalling() {
        Vector3 direction = _PhysicsPlayer.HorizontalDirection;
        Vector2 currentVelocity = _PhysicsPlayer.CurrentVelocity;
        AnalogInputAffects(ref direction, ref currentVelocity);

        _HorizontalMovement.HorizontalMovementDisplacement(ref direction);
        float yPlacement = FallCalculation().y;
        direction.y = yPlacement;

        _PhysicsPlayer.AerialHorizontalMoveCheck(direction);

        direction = _PhysicsPlayer.HorizontalDirection + (_PhysicsPlayer.CalculateHorizontalDirectionMidAir() / _MidAirReduction);
        _HorizontalMovement.HorizontalMovementDisplacement(ref direction);
        direction.y = yPlacement;

        _PlayerRigidbody.MovePosition(direction);
        _PhysicsPlayer.AttractToGround();
    }

    #region Private Functions
    private Vector3 FallCalculation() {
        Vector2 currentVelocity = _PhysicsPlayer.CurrentVelocity;
        Vector3 currentPosition = _PlayerTransform.position;

        Calculation(ref currentPosition, ref currentVelocity);

        if (currentVelocity.y > _MaxFallSpeed) { //Prevent the player from fall faster than a specified speed
            _PhysicsPlayer.CurrentVelocity = currentVelocity;
        }

        return currentPosition;
    }

    private Vector3 JumpCalculation() {
        Vector2 currentVelocity = _PhysicsPlayer.CurrentVelocity;
        Vector3 currentPosition = _PlayerTransform.position;

        Calculation(ref currentPosition, ref currentVelocity);

        _PhysicsPlayer.CurrentVelocity = currentVelocity; //Store the new velocity 

        _CeilingPhysics.VelocityCheck(); //Check to see if the player has reached the max height of their jump

        return currentPosition;
    }

    private void Calculation(ref Vector3 currentPosition, ref Vector2 currentVelocity) {
        currentPosition.y += (currentVelocity.y * Time.deltaTime) + (0.5f * _FallSpeed * Mathf.Pow(Time.deltaTime, 2));  //Calculate new displacement value
        currentVelocity.y += (_FallSpeed * Time.deltaTime); //Calculate new vertical velocity 
    }

    private void AnalogInputAffects(ref Vector3 direction, ref Vector2 currentVelocity) {
        Vector2 analogInput = _PhysicsPlayer.AnalogInput;

        if (analogInput.x > 0.01f || analogInput.y < -0.01f) { //Check to see if the player is attempting to alter their fall/jump direction while in mid air
            direction += (_PhysicsPlayer.CalculateHorizontalDirectionMidAir() / _MidAirReduction); //Reduce the impact of the player's ablity to change their horizontal direction while in midair
        }

        if (analogInput.y < 0.0f) { //Check to see if the player is attempting to cancel/mitigate their horizontal velocity
            float diff = currentVelocity.x - _HorizontalDecayRate;
            if (diff > _MinAirMoveSpeed) { //Allow the player to slow down in the horizontal direction, but don't let them fully cancel theit horizontal momentum 
                currentVelocity.x = diff;
                _PhysicsPlayer.CurrentVelocity = currentVelocity;
            }
        }

        if (currentVelocity.x < _MinAirMoveSpeed) { //If the player is in a midair horizontal move state, they should allow have a small amount of horizontal velocity
            currentVelocity.x = _MinAirMoveSpeed; //This value is not set to the true velocity as it was not initalized by the player themselves, thus it only will exist in a single frame's scope
        }
    }
    #endregion
}
