using UnityEngine;

public class PlayerEvent : IEventManager, IPhysicsEventInput {
    private IPlayerEvent _CurrentPlayerEvent;

    private PlayerPhysics _PhysicsPlayer;
    private readonly PlayerCamera _CameraPlayer;

    private readonly PlayerIdleEvent _IdleEvent;
    private readonly PlayerWalkEvent _WalkEvent;
    private readonly PlayerSprintEvent _SprintEvent;
    private readonly PlayerFallEvent _FallEvent;

    public PlayerEvent(Rigidbody playerRigidbody, PlayerCamera playerCamera) {
        _PhysicsPlayer = new PlayerPhysics(playerRigidbody);
        _CameraPlayer = playerCamera;

        _IdleEvent = new PlayerIdleEvent();
        _WalkEvent = new PlayerWalkEvent(_PhysicsPlayer, playerRigidbody);
        _SprintEvent = new PlayerSprintEvent(_PhysicsPlayer, playerRigidbody);
        _FallEvent = new PlayerFallEvent(_PhysicsPlayer, playerRigidbody);

        _CurrentPlayerEvent = _IdleEvent;
    }

    public ref IPlayerEvent CurrentPlayerEvent() { return ref _CurrentPlayerEvent; }
    public PlayerPhysics PhysicsPlayer() { return _PhysicsPlayer; }

    public void IdleEvent() {
        _PhysicsPlayer.SetBodyStanding();
        _CurrentPlayerEvent = _IdleEvent;
    }

    public void WalkEvent() {
        _PhysicsPlayer.SetBodyStanding();
        _CurrentPlayerEvent = _WalkEvent;
    }

    public void SprintEvent() {
        _PhysicsPlayer.SetBodyStanding();
        _CurrentPlayerEvent = _SprintEvent;
    }

    public void FallEvent() {
        _PhysicsPlayer.SetBodyStanding();
        _CurrentPlayerEvent = _FallEvent;
    }

    public void CrouchEvent() {
        _PhysicsPlayer.SetBodyCrouching();
        return;
    }

    public void CrouchWalkEvent() {
        _PhysicsPlayer.SetBodyCrouching();
        return;
    }

    public void CrouchJumpEvent() {
        _PhysicsPlayer.SetBodyCrouching();
        return;
    }

    public void AirMoveFallEvent() {
        _PhysicsPlayer.SetBodyStanding();
        return;
    }

    public void AirMoveCrouchFallEvent() {
        _PhysicsPlayer.SetBodyCrouching();
        return;
    }

    public void AirMoveCrouchJumpEvent() {
        _PhysicsPlayer.SetBodyCrouching();
        return;
    }

    public void AirMoveJumpEvent() {
        _PhysicsPlayer.SetBodyStanding();
        return;
    }

    public void JumpEvent() {
        _PhysicsPlayer.SetBodyStanding();
        return;
    }

    public void SlideEvent() {
        _PhysicsPlayer.SetBodyCrouching();
        return;
    }
}
