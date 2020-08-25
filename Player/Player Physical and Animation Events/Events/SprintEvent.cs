using UnityEngine;

public class SprintEvent : IPlayerEvent, IInputObserver {
    private IHorizontalMovementGround _MovementHorizontal;
    private float _SprintMaxVelocity;
    private Vector2 _InputDirection;


    public SprintEvent(IHorizontalMovementGround horizontalMovement) {
        _MovementHorizontal = horizontalMovement;
        _SprintMaxVelocity = 6.0f;
        _InputDirection = Vector2.zero;
    }

    public void ExecuteEvent() {
        _MovementHorizontal.MoveHorizontallyGround(_InputDirection, _SprintMaxVelocity);
    }

    public void Update(Vector2 direction) {
        _InputDirection = direction;
    }
}
