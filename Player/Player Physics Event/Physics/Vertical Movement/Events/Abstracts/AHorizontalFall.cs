using UnityEngine;

public abstract class AHorizontalFall {
    protected Rigidbody _PlayerRigidbody;
    protected Transform _PlayerTransform;
    protected PlayerPhysics _PhysicsPlayer;
    protected IPhysicsComponent _FallComponent;
    private float _MidAirReduction = 4.0f;
    private float _MinAirMoveSpeed = 0.1f;

    public void MovePlayer() {
        Vector3 direction = _PhysicsPlayer.HorizontalDirection() + (_PhysicsPlayer.CalculateHorizontalDirectionMidAir() / _MidAirReduction); //Ensure that if the player moves, they can only move slightly while in mid air
        Vector2 analogInput = _PhysicsPlayer.AnalogInput;
        Vector2 currentHorizontalSpeed = _PhysicsPlayer.CurrentVelocity;

        if (analogInput.y < 0.0f) { //If the player pulls back on the stick, slow their horizontal speed down when falling
            float diff = currentHorizontalSpeed.x + analogInput.y;
            if (diff >= _MinAirMoveSpeed) {
                currentHorizontalSpeed.x = diff;
                _PhysicsPlayer.CurrentVelocity = currentHorizontalSpeed;
            }
        }

        if(currentHorizontalSpeed.x < _MinAirMoveSpeed) { //The player should always have a little of movement speed in a falling horizontal move event
            currentHorizontalSpeed.x = _MinAirMoveSpeed;
        }

        direction = (direction * currentHorizontalSpeed.x * Time.deltaTime) + _PlayerTransform.position;
        float yPlacement = _FallComponent.CalculationComponent().y;
        direction.y = yPlacement;

        _PhysicsPlayer.AerialHorizontalMoveCheck(direction);

        direction = _PhysicsPlayer.HorizontalDirection() + (_PhysicsPlayer.CalculateHorizontalDirectionMidAir() / _MidAirReduction);
        direction = (direction * currentHorizontalSpeed.x * Time.deltaTime) + _PlayerTransform.position;
        direction.y = yPlacement;

        _PlayerRigidbody.MovePosition(direction);
    }
}
