using UnityEngine;

public class PlayerInputController {
    private PlayerInputDeviceController _InputDeviceController;
    #region Gameplay Input Classes
    private Input_Walk _InputWalk;
    private Input_Sprint _InputSprint;
    private Input_Crouch _InputCrouch;
    private Input_Jump _InputJump;
    private Input_Interact _InputInteract;
    private Input_Look _InputLook;
    #endregion
    #region Gamplay & Menu Input Classes
    private Input_GameMenu _InputGameMenu;
    #endregion
    #region Menu Input Classes
    private Input_NavigateUp _InputNavigateUp;
    private Input_NavigateDown _InputNavigateDown;
    private Input_NavigateLeft _InputNavigateLeft;
    private Input_NavigateRight _InputNavigateRight;
    #endregion
    public PlayerInputController(PlayerStateController playerProxies, PlayerPhysicsController physicsController, PlayerCameraController cameraController, PlayerUIController uiController) {
        _InputDeviceController = new PlayerInputDeviceController();
        InitializeInputEvent(playerProxies, cameraController, uiController);
        SetupObservers(physicsController, cameraController);
    }

    private void InitializeInputEvent(PlayerStateController playerProxies, PlayerCameraController cameraController, PlayerUIController uiController) {
        /**
          * @desc Initialize the input events and assign them to the _InputDeviceController so that once an button/analog is updated the appropriate funtions are called
        */
        _InputWalk = new Input_Walk(playerProxies.GetWalkProxy());
        _InputSprint = new Input_Sprint(playerProxies.GetSprintProxy());
        _InputCrouch = new Input_Crouch(playerProxies.GetCrouchProxy());
        _InputJump = new Input_Jump();
        _InputInteract = new Input_Interact();
        _InputLook = new Input_Look(cameraController.GetLookProxy());
        _InputGameMenu = new Input_GameMenu(this, uiController);
        _InputNavigateUp = new Input_NavigateUp(uiController);
        _InputNavigateDown = new Input_NavigateDown(uiController);
        _InputNavigateLeft = new Input_NavigateLeft(uiController);
        _InputNavigateRight = new Input_NavigateRight(uiController);

        #region Gameplay input functionality setup
        //Walk input events
        _InputDeviceController.Gameplay.Walk.started += ctx => _InputWalk.InputStart(ctx.ReadValue<Vector2>());
        _InputDeviceController.Gameplay.Walk.performed += ctx => _InputWalk.InputUpdate(ctx.ReadValue<Vector2>());
        _InputDeviceController.Gameplay.Walk.canceled += ctx => _InputWalk.InputEnd();

        //Sprint input events
        _InputDeviceController.Gameplay.Sprint.started += ctx => _InputSprint.InputStart();
        _InputDeviceController.Gameplay.Sprint.canceled += ctx => _InputSprint.InputEnd();

        //Crouch input events
        _InputDeviceController.Gameplay.Crouch.started += ctx => _InputCrouch.InputStart();
        _InputDeviceController.Gameplay.Crouch.canceled += ctx => _InputCrouch.InputEnd();

        //Jump input events
        _InputDeviceController.Gameplay.Jump.started += ctx => _InputJump.InputStart();
        _InputDeviceController.Gameplay.Jump.canceled += ctx => _InputJump.InputEnd();

        //Interact input events (Pick up items, start quest, reload weapons, and open chests)
        _InputDeviceController.Gameplay.Interact.started += ctx => _InputInteract.InputStart();
        _InputDeviceController.Gameplay.Interact.canceled += ctx => _InputInteract.InputEnd();

        //Move player's camera input events
        _InputDeviceController.Gameplay.Look.started += ctx => _InputLook.InputStart(ctx.ReadValue<Vector2>());
        _InputDeviceController.Gameplay.Look.performed += ctx => _InputLook.InputUpdate(ctx.ReadValue<Vector2>());
        _InputDeviceController.Gameplay.Look.canceled += ctx => _InputLook.InputEnd();

        //Brings up the game menu and disables the player's HUD
        _InputDeviceController.Gameplay.GameMenu.started += ctx => _InputGameMenu.Gameplay_InputStart();
        #endregion
        #region Menu input functionality setup
        //UI up navigation
        _InputDeviceController.Menu.Up.started += ctx => _InputNavigateUp.InputStart(ctx.ReadValue<float>());
        _InputDeviceController.Menu.Up.canceled += ctx => _InputNavigateUp.InputEnd();

        //UI down navigation
        _InputDeviceController.Menu.Down.started += ctx => _InputNavigateDown.InputStart(ctx.ReadValue<float>());
        _InputDeviceController.Menu.Down.canceled += ctx => _InputNavigateDown.InputEnd();

        //UI right navigation
        _InputDeviceController.Menu.Right.started += ctx => _InputNavigateRight.InputStart(ctx.ReadValue<float>());
        _InputDeviceController.Menu.Right.canceled += ctx => _InputNavigateRight.InputEnd();

        //UI left navigation
        _InputDeviceController.Menu.Right.started += ctx => _InputNavigateLeft.InputStart(ctx.ReadValue<float>());
        _InputDeviceController.Menu.Right.canceled += ctx => _InputNavigateLeft.InputEnd();

        //Click UI element

        //Close any active UI element and bring player's UI back to the HUD element
        _InputDeviceController.Menu.ExitMenu.started += ctx => _InputGameMenu.Menu_InputStart();
        #endregion
    }

    private void SetupObservers(PlayerPhysicsController physicsController, PlayerCameraController cameraController) {
        /**
          * @desc Setup up all observer objects with an observable input class so observers can be informed of input changes as they happen
          * @parm PlayerEventController $playerEvents - Holds physics events that are observers that require input observable classes
          * @parm PlayerCameraController $cameraController - Holds the camera event that will observer the required input observable class 
        */
        _InputWalk.GetLeftAnalogObservable().AddObserver(physicsController);
        _InputLook.GetRightAnalogObservable().AddObserver(cameraController);
    }

    public void StartGamePlayInuptController() {
        /**
          * @desc Switch the player's input device to work for gameplay
        */
        _InputDeviceController.Gameplay.Enable();
        _InputDeviceController.Menu.Disable();
    }

    public void StartMenuInputController() {
        /**
          * @desc Switch the player's input device to work for game menus
        */
        _InputDeviceController.Menu.Enable();
        _InputDeviceController.Gameplay.Disable();
    }
}
