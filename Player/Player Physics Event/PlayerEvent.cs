using UnityEngine;

public class PlayerEvent : IEventManager, IPhysicsEventInput {
    private IPlayerEvent _CurrentPlayerEvent;

    private PlayerPhysics _PhysicsPlayer;
    private readonly PlayerCamera _CameraPlayer;

    private readonly PlayerIdleEvent _IdleEvent;
    private readonly PlayerWalkEvent _WalkEvent;
    private readonly PlayerSprintEvent _SprintEvent;
    private readonly PlayerFallEvent _FallEvent;
    private readonly PlayerCrouchEvent _CrouchEvent;
    private readonly PlayerCrouchWalk _CrouchWalkEvent;
    private readonly PlayerAirMoveFallEvent _AirMoveFallEvent;
    private readonly PlayerAirMoveCrouchFallEvent _AirMoveCrouchFallEvent;

    public PlayerEvent(Rigidbody playerRigidbody, PlayerCamera playerCamera) {
        _PhysicsPlayer = new PlayerPhysics(playerRigidbody);
        _CameraPlayer = playerCamera;

        _IdleEvent = new PlayerIdleEvent(_PhysicsPlayer);
        _CrouchEvent = new PlayerCrouchEvent(_PhysicsPlayer);
        _WalkEvent = new PlayerWalkEvent(_PhysicsPlayer, playerRigidbody);
        _SprintEvent = new PlayerSprintEvent(_PhysicsPlayer, playerRigidbody);
        _FallEvent = new PlayerFallEvent(_PhysicsPlayer, playerRigidbody);
        _CrouchWalkEvent = new PlayerCrouchWalk(_PhysicsPlayer, playerRigidbody);
        _AirMoveFallEvent = new PlayerAirMoveFallEvent(_PhysicsPlayer, playerRigidbody, _FallEvent);
        _AirMoveCrouchFallEvent = new PlayerAirMoveCrouchFallEvent(_PhysicsPlayer, playerRigidbody, _FallEvent);

        _CurrentPlayerEvent = _IdleEvent;
    }

    public ref IPlayerEvent CurrentPlayerEvent() { return ref _CurrentPlayerEvent; }
    public PlayerPhysics PhysicsPlayer() { return _PhysicsPlayer; }

    public void IdleEvent() {
        _PhysicsPlayer.SetBodyStanding();
        _CameraPlayer.TransitionCameraStanding();
        _CurrentPlayerEvent = _IdleEvent;
    }

    public void WalkEvent() {
        _PhysicsPlayer.SetBodyStanding();
        _CameraPlayer.TransitionCameraStanding();
        _CurrentPlayerEvent = _WalkEvent;
    }

    public void SprintEvent() {
        _PhysicsPlayer.SetBodyStanding();
        _CameraPlayer.TransitionCameraStanding();
        _CurrentPlayerEvent = _SprintEvent;
    }

    public void FallEvent() {
        _PhysicsPlayer.SetBodyStanding();
        _CameraPlayer.TransitionCameraStanding();
        _CurrentPlayerEvent = _FallEvent;
    }

    public void CrouchEvent() {
        _PhysicsPlayer.SetBodyCrouching();
        _CameraPlayer.TransitionCameraCrouching();
        _CurrentPlayerEvent = _CrouchEvent;
    }

    public void CrouchWalkEvent() {
        _PhysicsPlayer.SetBodyCrouching();
        _CameraPlayer.TransitionCameraCrouching();
        _CurrentPlayerEvent = _CrouchWalkEvent;
    }

    public void AirMoveFallEvent() {
        _PhysicsPlayer.SetBodyStanding();
        _CameraPlayer.TransitionCameraStanding();
        _CurrentPlayerEvent = _AirMoveFallEvent;
    }

    public void AirMoveCrouchFallEvent() {
        _PhysicsPlayer.SetBodyCrouching();
        _CameraPlayer.TransitionCameraCrouching();
        _CurrentPlayerEvent = _AirMoveCrouchFallEvent;
    }

    public void CrouchJumpEvent() {
        _PhysicsPlayer.SetBodyCrouching();
        _CameraPlayer.TransitionCameraCrouching();
        return;
    }

    public void AirMoveCrouchJumpEvent() {
        _PhysicsPlayer.SetBodyCrouching();
        _CameraPlayer.TransitionCameraCrouching();
        return;
    }

    public void AirMoveJumpEvent() {
        _PhysicsPlayer.SetBodyStanding();
        _CameraPlayer.TransitionCameraStanding();
        return;
    }

    public void JumpEvent() {
        _PhysicsPlayer.SetBodyStanding();
        _CameraPlayer.TransitionCameraStanding();
        return;
    }

    public void SlideEvent() {
        _PhysicsPlayer.SetBodyCrouching();
        _CameraPlayer.TransitionCameraCrouching();
        return;
    }
}
