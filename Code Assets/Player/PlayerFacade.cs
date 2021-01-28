using UnityEngine;

public class PlayerFacade {
    private readonly PlayerInput _InputPlayer;
    private readonly PlayerState _StatePlayer;
    private readonly PlayerEvent _EventPlayer;
    private readonly PlayerCamera _CameraPlayer;
    private readonly PlayerUI _UIPlayer;
    private readonly PlayerVariable _VariablePlayer;
    private readonly PlayerInventory _InventoryPlayer;

    private readonly PhysicsGrounded _GroundCheck;

    public PlayerFacade(Rigidbody playerRigidbody, Camera playerCamera, PlayerMain playerMain, PlayerUIController uiController) {
        _CameraPlayer = new PlayerCamera(playerRigidbody.transform, playerCamera, playerMain);
        _EventPlayer = new PlayerEvent(playerRigidbody, _CameraPlayer);
        _VariablePlayer = new PlayerVariable();
        _UIPlayer = new PlayerUI(_VariablePlayer, uiController);
        _InventoryPlayer = new PlayerInventory();

        PhysicsItemPickup itemDetection = _EventPlayer.PhysicsPlayer().GetItemPickupCheck();
        itemDetection.PlayerInventory = _InventoryPlayer;
        itemDetection.PlayerUiDisplay = _UIPlayer;
        
        _StatePlayer = new PlayerState(_EventPlayer, itemDetection);
        _InputPlayer = new PlayerInput(_StatePlayer, _EventPlayer, _CameraPlayer);

        _GroundCheck = _EventPlayer.PhysicsPlayer().GetGroundCheck();
        _GroundCheck.SetFallProxy(_StatePlayer.ProxyFall());
        _EventPlayer.PhysicsPlayer().GetCeilingCheck().SetJumpProxy(_StatePlayer.ProxyJumpPhysics());
        _EventPlayer.PhysicsPlayer().GetWallCheck().SetWalkProxy(_StatePlayer.ProxyWalk());

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
        _UIPlayer.UpdateUIDisplay();
    }
}
