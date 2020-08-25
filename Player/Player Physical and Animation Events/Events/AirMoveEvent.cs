using UnityEngine;

public class AirMoveEvent : IPlayerEvent, IInputObserver {
    private IHorizontalMovementAir _MovementHorizontal;
    private float _AirMoveMaxVelocity;
    private Vector2 _InputDirection;

    public AirMoveEvent(IHorizontalMovementAir horizontalMovement) {
        _MovementHorizontal = horizontalMovement;
        _AirMoveMaxVelocity = 1.0f;
        _InputDirection = Vector2.zero;
    }

    public void ExecuteEvent() {
        _MovementHorizontal.MoveHorizontallyAir(_InputDirection, _AirMoveMaxVelocity);
    }

    public void Update(Vector2 direction) {
        _InputDirection = direction;
    }
}
