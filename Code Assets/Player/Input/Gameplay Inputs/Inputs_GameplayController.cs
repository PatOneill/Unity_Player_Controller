using UnityEngine;

public class Inputs_GameplayController : IObservableMovePlayerBody, IObservableRotateCamera {
    private AnalogInputEventObservable _RotateCameraObserver;
    private AnalogInputEventObservable _MovePlayerBodyObserver;

    private InputEvent_MovePlayerBody _InputEventMovePlayerBody;
    private InputEvent_RotateCamera _InputEventRotateCamera;


    public IAnalogInputEventAddObserver GetObservableMovePlayerBody => _MovePlayerBodyObserver;
    public IAnalogInputEventAddObserver GetObservableRotateCamera => _RotateCameraObserver;

    public Inputs_GameplayController(PlayerInputs inputDevice) {
        _RotateCameraObserver = new AnalogInputEventObservable();
        _MovePlayerBodyObserver = new AnalogInputEventObservable();
        
        _InputEventMovePlayerBody = new InputEvent_MovePlayerBody(_MovePlayerBodyObserver);
        #region MovePlayerBody Input Event Setup
        inputDevice.GameplayInput.MovePlayerBody.started += CallbackContext => _InputEventMovePlayerBody.AnalogInputEventStart(CallbackContext.ReadValue<Vector2>());
        inputDevice.GameplayInput.MovePlayerBody.performed += CallbackContext => _InputEventMovePlayerBody.AnalogInputEventPerform(CallbackContext.ReadValue<Vector2>());
        inputDevice.GameplayInput.MovePlayerBody.canceled += CallbackContext => _InputEventMovePlayerBody.AnalogInputEventCancel();
        #endregion
        _InputEventRotateCamera = new InputEvent_RotateCamera(_RotateCameraObserver);
        #region RotateCamera Input Event Setup
        inputDevice.GameplayInput.RotateCamera.started += CallbackContext => _InputEventRotateCamera.AnalogInputEventStart(CallbackContext.ReadValue<Vector2>());
        inputDevice.GameplayInput.RotateCamera.performed += CallbackContext => _InputEventRotateCamera.AnalogInputEventPerform(CallbackContext.ReadValue<Vector2>());
        inputDevice.GameplayInput.RotateCamera.canceled += CallbackContext => _InputEventRotateCamera.AnalogInputEventCancel();
        #endregion
    }
}
