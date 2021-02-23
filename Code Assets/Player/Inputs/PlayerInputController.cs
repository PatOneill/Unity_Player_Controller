using UnityEngine;

public class PlayerInputController {
    private PlayerInputDeviceController _InputDeviceController;
    private Input_RightAnalog _InputEventRightAnalog;
    private Input_LeftAnalog _InputEventLeftAnalog;
    private Input_AButton _InputEventAButton;
    private Input_BButton _InputEventBButton;
    private Input_XButton _InputEventXButton;

    public PlayerInputController(PlayerStateController playerProxies, PlayerPhysicsController physicsController, PlayerCameraController cameraController) {
        _InputDeviceController = new PlayerInputDeviceController();
        InitializeInputEvent(playerProxies, cameraController);
        SetupObservers(physicsController, cameraController);
    }

    private void InitializeInputEvent(PlayerStateController playerProxies, PlayerCameraController cameraController) {
        /**
          * @desc Initialize the input events and assign them to the _InputDeviceController so that once an button/analog is updated the appropriate funtions are called
          * @parm PlayerStateController $playerProxies - Used to initialize each input class with a corresponding proxy 
          * @parm PlayerCameraController $cameraController - Used to initialize the look input class with the corresponding look proxy
        */
        _InputEventRightAnalog = new Input_RightAnalog(cameraController.GetLookProxy()); 
        _InputEventLeftAnalog = new Input_LeftAnalog(playerProxies.GetWalkProxy(), playerProxies.GetSprintProxy());
        _InputEventAButton = new Input_AButton();
        _InputEventBButton = new Input_BButton(playerProxies.GetCrouchProxy());
        _InputEventXButton = new Input_XButton();

        //Walk input events
        _InputDeviceController.Gameplay.Walk.started += ctx => _InputEventLeftAnalog.GamePlay_InputStartWalk(ctx.ReadValue<Vector2>());
        _InputDeviceController.Gameplay.Walk.performed += ctx => _InputEventLeftAnalog.GamePlay_InputUpdateWalk(ctx.ReadValue<Vector2>());
        _InputDeviceController.Gameplay.Walk.canceled += ctx => _InputEventLeftAnalog.GamePlay_InputEndWalk();

        //Sprint input events
        _InputDeviceController.Gameplay.Sprint.started += ctx => _InputEventLeftAnalog.GamePlay_InputStartSprint();
        _InputDeviceController.Gameplay.Sprint.canceled += ctx => _InputEventLeftAnalog.GamePlay_InputEndSprint();

        //Move player's camera input events
        _InputDeviceController.Gameplay.Look.started += ctx => _InputEventRightAnalog.GamePlay_InputStart(ctx.ReadValue<Vector2>());
        _InputDeviceController.Gameplay.Look.performed += ctx => _InputEventRightAnalog.GamePlay_InputUpdate(ctx.ReadValue<Vector2>());
        _InputDeviceController.Gameplay.Look.canceled += ctx => _InputEventRightAnalog.GamePlay_InputEnd();

        //Jump input events
        _InputDeviceController.Gameplay.Jump.started += ctx => _InputEventAButton.GamePlay_InputStart();
        _InputDeviceController.Gameplay.Jump.canceled += ctx => _InputEventAButton.GamePlay_InputEnd();

        //Crouch input events
        _InputDeviceController.Gameplay.Crouch.started += ctx => _InputEventBButton.GamePlay_InputStart();
        _InputDeviceController.Gameplay.Crouch.canceled += ctx => _InputEventBButton.GamePlay_InputEnd();

        //Interact input events (Pick up items, start quest, reload weapons, and open chests)
        _InputDeviceController.Gameplay.Interact.started += ctx => _InputEventXButton.GamePlay_InputStart();
        _InputDeviceController.Gameplay.Interact.canceled += ctx => _InputEventXButton.GamePlay_InputEnd();
    }

    private void SetupObservers(PlayerPhysicsController physicsController, PlayerCameraController cameraController) {
        /**
          * @desc Setup up all observer objects with an observable input class so observers can be informed of input changes as they happen
          * @parm PlayerEventController $playerEvents - Holds physics events that are observers that require input observable classes
          * @parm PlayerCameraController $cameraController - Holds the camera event that will observer the required input observable class 
        */
        _InputEventLeftAnalog.GetLeftAnalogObservable().AddObserver(physicsController);
        _InputEventRightAnalog.GetRightAnalogObservable().AddObserver(cameraController);
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
