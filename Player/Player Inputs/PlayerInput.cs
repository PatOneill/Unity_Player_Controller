using UnityEngine;

public class PlayerInput {
    private InputDeviceLayout _InputDeviceLayout;
    private readonly IToggleInput _EventSprint;
    private readonly IToggleInput _EventCrouch;
    private readonly IAnalogInput _EventWalk;
    private readonly IAnalogInput _EventLook;
    private readonly IButtonReleaseInput _EventJump;

    public PlayerInput(IStateProxyInput playerStates, IPhysicsEventInput playerEvent, ICameraInput playerCamera) {
        _InputDeviceLayout = new InputDeviceLayout();

        #region Initialize Input Functionality
        //Toggle inputs 
        _EventSprint = new Input_SprintEvent(playerStates.ProxySprint());
        _EventCrouch = new Input_CrouchEvent(playerStates.ProxyCrouch());

        //Analog stick inputs
        _EventWalk = new Input_WalkeEvent(playerStates.ProxyWalk());
        _EventLook = new Input_LookEvent(playerCamera.ProxyLook());

        //Button release inputs
        _EventJump = new Input_JumpEvent(playerStates.ProxyJump());
        #endregion

        #region Set Up Observers
        _EventWalk.GetObservable().AddObserver(playerStates.ProxySprintObserver());
        _EventWalk.GetObservable().AddObserver(playerEvent.PhysicsPlayer());
        _EventLook.GetObservable().AddObserver(playerCamera);
        #endregion

        #region Input Device Callback Functions
        //Analog inputs callback functions
        _InputDeviceLayout.Player.Walk.started += ctx => _EventWalk.AnalogStart(ctx.ReadValue<Vector2>());
        _InputDeviceLayout.Player.Walk.performed += ctx => _EventWalk.AnalogPerform(ctx.ReadValue<Vector2>());
        _InputDeviceLayout.Player.Walk.canceled += ctx => _EventWalk.AnalogCancel();

        _InputDeviceLayout.Player.Look.started += ctx => _EventLook.AnalogStart(ctx.ReadValue<Vector2>());
        _InputDeviceLayout.Player.Look.performed += ctx => _EventLook.AnalogPerform(ctx.ReadValue<Vector2>());
        _InputDeviceLayout.Player.Look.canceled += ctx => _EventLook.AnalogCancel();

        //Button release inputs callback functions
        _InputDeviceLayout.Player.Jump.started += ctx => _EventJump.ButtonStart();

        //Button hold inputs callback functions

        //Toogle inputs callback functions
        _InputDeviceLayout.Player.Sprint.started += ctx => _EventSprint.TogglePressed();
        _InputDeviceLayout.Player.Crouch.started += ctx => _EventCrouch.TogglePressed();

        #endregion
    }

    public void ActivateInputDevice() {
        _InputDeviceLayout.Enable(); //Start monitoring the input device (Only the Xbox One controller is supported currently)
    }

    public void DisableInputDevice() {
        _InputDeviceLayout.Disable(); //Stop monitoring the input device (Only the Xbox One controller is supported currently)
    }
}
