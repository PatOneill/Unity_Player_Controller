using UnityEngine;

public class PlayerMainFacade {
    private PlayerInputController _InputControllerPlayer;
    private PlayerStateController _StateControllerPlayer;
    private PlayerEventController _EventControllerPlayer;
    private PlayerStatsController _StatsControllerPlayer;
    private PlayerPhysicsController _PhysicsControllerPlayer;
    private PlayerCameraController _CameraControllerPlayer;

    public PlayerMainFacade(Rigidbody playerPhysicsBody, Camera playerCamera) {
        _StatsControllerPlayer = new PlayerStatsController();
        _CameraControllerPlayer = new PlayerCameraController(playerCamera, playerPhysicsBody);
        _PhysicsControllerPlayer = new PlayerPhysicsController(playerPhysicsBody);
        _EventControllerPlayer = new PlayerEventController(_StatsControllerPlayer, _PhysicsControllerPlayer);
        _StateControllerPlayer = new PlayerStateController(_EventControllerPlayer, _StatsControllerPlayer);
        _InputControllerPlayer = new PlayerInputController(_StateControllerPlayer, _EventControllerPlayer, _CameraControllerPlayer);
        _InputControllerPlayer.StartGamePlayInuptController(); //Initialize input capture for gameplay as soon as the player spawns in the level
    }

    public void FacadeStart() {
        return;
    }

    public void FacadeFixedUpdate() {
        _CameraControllerPlayer.InputDrivenPlayerCameraMotion();
        _EventControllerPlayer.ExecuteCurrentEvent();
        _StatsControllerPlayer.AutoStatRecovery(); 
    }

    public void FacadeUpdate() {
        return;
    }

    public void FacadeLateUpdate() {
        return;
    }
}
