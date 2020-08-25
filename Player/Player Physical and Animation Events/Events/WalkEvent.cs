using UnityEngine;

public class WalkEvent : IPlayerEvent, IInputObserver {
    private IHorizontalMovementGround _MovementHorizontal;
    private float _WalkMaxVelocity;
    private Vector2 _InputDirection;

    public WalkEvent(IHorizontalMovementGround horizontalMovement) {
        _MovementHorizontal = horizontalMovement;
        _WalkMaxVelocity = 3.0f;
        _InputDirection = Vector2.zero;
    }

    public void ExecuteEvent() {
        _MovementHorizontal.MoveHorizontallyGround(_InputDirection, _WalkMaxVelocity);
    }

    public void Update(Vector2 direction) {
        _InputDirection = direction;
    }
}
