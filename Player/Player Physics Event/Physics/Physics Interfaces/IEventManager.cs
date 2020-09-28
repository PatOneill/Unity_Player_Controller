public interface IEventManager {
    void IdleEvent();

    void WalkEvent();

    void SprintEvent();

    void JumpEvent();

    void FallEvent();

    void CrouchEvent();

    void SlideEvent();

    void CrouchWalkEvent();

    void CrouchJumpEvent();

    void AirMoveJumpEvent();

    void AirMoveFallEvent();

    void AirMoveCrouchJumpEvent();

    void AirMoveCrouchFallEvent();
}
