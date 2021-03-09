using UnityEngine;

public class PlayerMainFacade {
    private PlayerInputController _InputControllerPlayer;
    private PlayerStateController _StateControllerPlayer;
    private PlayerEventController _EventControllerPlayer;
    private PlayerStatsController _StatsControllerPlayer;
    private PlayerPhysicsController _PhysicsControllerPlayer;
    private PlayerCameraController _CameraControllerPlayer;
    private PlayerAnimationController _AnimationControllerPlayer;
    private PlayerUIController _UIControllerPlayer;
    

    public PlayerMainFacade(Rigidbody playerPhysicsBody, Animator playerAnimator, Camera playerCamera, UnityUIController unityUI) {
        _UIControllerPlayer = new PlayerUIController(unityUI);
        _StatsControllerPlayer = new PlayerStatsController(_UIControllerPlayer);
        _CameraControllerPlayer = new PlayerCameraController(playerCamera, playerPhysicsBody);
        _PhysicsControllerPlayer = new PlayerPhysicsController(playerPhysicsBody);
        _AnimationControllerPlayer = new PlayerAnimationController(playerAnimator, _PhysicsControllerPlayer);
        _EventControllerPlayer = new PlayerEventController(_StatsControllerPlayer, _PhysicsControllerPlayer, _AnimationControllerPlayer);
        _StateControllerPlayer = new PlayerStateController(_EventControllerPlayer, _StatsControllerPlayer);
        _InputControllerPlayer = new PlayerInputController(_StateControllerPlayer, _PhysicsControllerPlayer, _CameraControllerPlayer);
        _InputControllerPlayer.StartGamePlayInuptController(); //Initialize input capture for gameplay as soon as the player spawns in the level
    }

    public void FacadeStart() {
        _UIControllerPlayer.SetUIElements();
    }

    public void FacadeFixedUpdate() {
        _EventControllerPlayer.ExecuteCurrentEvent();
    }

    public void FacadeUpdate() {
        _StatsControllerPlayer.AutoStatRecovery();
    }

    public void FacadeLateUpdate() {
        _CameraControllerPlayer.InputDrivenPlayerCameraMotion();
    }
}
