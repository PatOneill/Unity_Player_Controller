using UnityEngine;

public class PlayerEvent : IEventManager, IPhysicsEventInput {
    private IPlayerEvent _CurrentPlayerEvent;

    private PlayerPhysics _PhysicsPlayer;
    private readonly PlayerVerticalMovement _VerticalMovement;
    private readonly PlayerHorizontalMovement _HorizontalMovement;
    private readonly PlayerCamera _CameraPlayer;

    private readonly PlayerIdleEvent _IdleEvent;
    private readonly PlayerCrouchEvent _CrouchEvent;

    private readonly PlayerWalkEvent _WalkEvent;
    private readonly PlayerCrouchWalk _CrouchWalkEvent;
    private readonly PlayerSprintEvent _SprintEvent;

    private readonly PlayerFallEvent _FallEvent;
    private readonly PlayerFallCrouchEvent _CrouchFallEvent;
    private readonly PlayerAirMoveFallEvent _AirMoveFallEvent;
    private readonly PlayerAirMoveCrouchFallEvent _AirMoveCrouchFallEvent;

    private readonly PlayerJumpEvent _JumpEvent;
    private readonly PlayerCrouchJumpEvent _CrouchJumpEvent;
    private readonly PlayerAirMoveCrouchJumpEvent _AirMoveCrouchJumpEvent;
    private readonly PlayerAirMoveJumpEvent _AirMoveJumpEvent;

    public PlayerEvent(Rigidbody playerRigidbody, PlayerCamera playerCamera) {
        _PhysicsPlayer = new PlayerPhysics(playerRigidbody);
        _HorizontalMovement = new PlayerHorizontalMovement(_PhysicsPlayer, playerRigidbody);
        _VerticalMovement = new PlayerVerticalMovement(_PhysicsPlayer, playerRigidbody);
        _CameraPlayer = playerCamera;

        _IdleEvent = new PlayerIdleEvent(_PhysicsPlayer);
        _CrouchEvent = new PlayerCrouchEvent(_PhysicsPlayer);

        _WalkEvent = new PlayerWalkEvent(_HorizontalMovement);
        _CrouchWalkEvent = new PlayerCrouchWalk(_HorizontalMovement);
        _SprintEvent = new PlayerSprintEvent(_HorizontalMovement);


        _FallEvent = new PlayerFallEvent(_VerticalMovement);
        _CrouchFallEvent = new PlayerFallCrouchEvent(_VerticalMovement);
        _AirMoveFallEvent = new PlayerAirMoveFallEvent(_VerticalMovement);
        _AirMoveCrouchFallEvent = new PlayerAirMoveCrouchFallEvent(_VerticalMovement);

        _JumpEvent = new PlayerJumpEvent(_VerticalMovement);
        _CrouchJumpEvent = new PlayerCrouchJumpEvent(_VerticalMovement);
        _AirMoveJumpEvent = new PlayerAirMoveJumpEvent(_VerticalMovement);
        _AirMoveCrouchJumpEvent = new PlayerAirMoveCrouchJumpEvent(_VerticalMovement);

        _CurrentPlayerEvent = _IdleEvent; //Starting Event
    }

    public ref IPlayerEvent CurrentPlayerEvent() { return ref _CurrentPlayerEvent; }

    public PlayerPhysics PhysicsPlayer() { return _PhysicsPlayer; }

    private void IsStanding() {
        _PhysicsPlayer.SetBodyStanding();
        _CameraPlayer.TransitionCameraStanding();
    }

    private void IsCrouching() {
        _PhysicsPlayer.SetBodyCrouching();
        _CameraPlayer.TransitionCameraCrouching();
    }

    #region Event Transitions 
    public void IdleEvent() {
        IsStanding();
        _CurrentPlayerEvent = _IdleEvent;
    }

    public void CrouchEvent() {
        IsCrouching();
        _CurrentPlayerEvent = _CrouchEvent;
    }

    public void WalkEvent() {
        IsStanding();
        _CurrentPlayerEvent = _WalkEvent;
    }

    public void CrouchWalkEvent() {
        IsCrouching();
        _CurrentPlayerEvent = _CrouchWalkEvent;
    }

    public void SprintEvent() {
        IsStanding();
        _CurrentPlayerEvent = _SprintEvent;
    }

    public void FallEvent() {
        IsStanding();
        _CurrentPlayerEvent = _FallEvent;
    }

    public void FallCrouchEvent() {
        IsCrouching();
        _CurrentPlayerEvent = _CrouchFallEvent;
    }

    public void AirMoveFallEvent() {
        IsStanding();
        _CurrentPlayerEvent = _AirMoveFallEvent;
    }

    public void AirMoveCrouchFallEvent() {
        IsCrouching();
        _CurrentPlayerEvent = _AirMoveCrouchFallEvent;
    }

    public void JumpEvent() {
        IsStanding();
        _PhysicsPlayer.SetInitialJumpVelocity(); //Sets the vertical velocity for a jump
        _CurrentPlayerEvent = _JumpEvent;
    }

    public void CrouchJumpEvent() {
        IsCrouching();
        _CurrentPlayerEvent = _CrouchJumpEvent;
    }

    public void AirMoveCrouchJumpEvent() {
        IsCrouching();
        _CurrentPlayerEvent = _AirMoveCrouchJumpEvent;
    }

    public void AirMoveJumpEvent() {
        IsStanding();
        _CurrentPlayerEvent = _AirMoveJumpEvent;
    }

    public void SlideEvent() {
        IsCrouching();
        return;
    }
    #endregion
}
