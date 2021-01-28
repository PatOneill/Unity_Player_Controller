public interface IState {
    void ChangeState(APlayerState newState);
    IdleState StateIdle();
    WalkState StateWalk();
    SprintState StateSprint();
    FallState StateFall();
    CrouchWalkState StateCrouchWalk();
    CrouchState StateCrouch();
    JumpState StateJump();
    SlideState StateSlide();
    CrouchJumpState StateCrouchJump();
    CrouchFallState StateCrouchFall();
    AirMoveCrouchFallState StateAirMoveCrouchFall();
    AirMoveCrouchJumpState StateAirMoveCrouchJump();
    AirMoveFallState StateAirMoveFall();
    AirMoveJumpState StateAirMoveJump();
}
