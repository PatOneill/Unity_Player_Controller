using UnityEngine;

public class PlayerInput {
    private InputDeviceLayout _InputDeviceLayout;
    private readonly Input_WalkeEvent _EventWalk;
    private readonly Input_SprintEvent _EventSprint;
    private readonly Input_LookEvent _EventLook;

    public PlayerInput(PlayerState playerStates, PlayerEvent playerEvent, PlayerCamera playerCamera) {
        _InputDeviceLayout = new InputDeviceLayout();

        #region Initialize Input Functionality
        _EventWalk = new Input_WalkeEvent(playerStates.ProxyWalk);
        _EventSprint = new Input_SprintEvent(playerStates.ProxySprint);
        _EventLook = new Input_LookEvent(playerStates.ProxyLook);
        #endregion

        #region Set Up Observers
        _EventWalk.AddObserver(playerEvent.PlayerWalkEvent);
        _EventWalk.AddObserver(playerEvent.PlayerSprintEvent);
        _EventWalk.AddObserver(playerEvent.PlayerAirMoveEvent);
        _EventLook.AddObserver(playerCamera);
        #endregion

        #region Setting Up Player Input Device
        _InputDeviceLayout.Player.Sprint.started += ctx => _EventSprint.SprintStart();

        _InputDeviceLayout.Player.Walk.started += ctx => _EventWalk.WalkStart(ctx.ReadValue<Vector2>());
        _InputDeviceLayout.Player.Walk.performed += ctx => _EventWalk.WalkPerformed(ctx.ReadValue<Vector2>());
        _InputDeviceLayout.Player.Walk.canceled += ctx => _EventWalk.WalkCanceled();

        _InputDeviceLayout.Player.Look.started += ctx => _EventLook.LookStart(ctx.ReadValue<Vector2>());
        _InputDeviceLayout.Player.Look.performed += ctx => _EventLook.LookPerformed(ctx.ReadValue<Vector2>());
        _InputDeviceLayout.Player.Look.canceled += ctx => _EventLook.LookCanceled();
        #endregion
    }

    public void ActivateInputDevice() {
        _InputDeviceLayout.Enable(); //Start monitoring the input device 
    }

    public void DisableInputDevice() {
        _InputDeviceLayout.Disable(); //Stop monitoring the input device
    }
}
