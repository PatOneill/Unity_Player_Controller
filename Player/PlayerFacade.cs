using UnityEngine;

public class PlayerFacade {
    private readonly PlayerInput _InputPlayer;
    private readonly PlayerState _StatePlayer;
    private readonly PlayerEvent _EventPlayer;
    private readonly PlayerCamera _CameraPlayer;

    private readonly PhysicsGrounded _GroundCheck;

    public PlayerFacade(Rigidbody playerRigidbody, Camera playerCamera, PlayerMain playerMain) {
        _CameraPlayer = new PlayerCamera(playerRigidbody.transform, playerCamera, playerMain);
        _EventPlayer = new PlayerEvent(playerRigidbody, _CameraPlayer);
        _StatePlayer = new PlayerState(_EventPlayer);
        _InputPlayer = new PlayerInput(_StatePlayer, _EventPlayer, _CameraPlayer);

        _GroundCheck = _EventPlayer.PhysicsPlayer().GetGroundCheck();
        _GroundCheck.SetFallProxy(_StatePlayer.ProxyFall());
        _EventPlayer.PhysicsPlayer().GetCeilingCheck().SetJumpProxy(_StatePlayer.ProxyJumpPhysics());

        _InputPlayer.ActivateInputDevice();
    }

    public void FacadeStart() {
        return;
    }

    public void FacadeFixedUpdate() {
        _EventPlayer.CurrentPlayerEvent().ExecutePhysicsEvent(); //Move the player's rigidbody according to the player's current active state
        _GroundCheck.CheckGround(); //Check to see if the player is on th ground
    }

    public void FacadeUpdate() {
        return;
    }

    public void FacadeLastUpdate() {
        _CameraPlayer.UpdateCamera(); //Rotates player (Research if the player's rigidbody would technically need to be rotated in fixed update)
        //_EventPlayer.CurrentPlayerEvent().ExecuteAnimationEvent(); //Update the player's animation controller according to the player's current active state
    }
}
