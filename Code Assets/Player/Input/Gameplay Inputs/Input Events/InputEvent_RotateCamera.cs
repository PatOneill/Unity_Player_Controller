using UnityEngine;

public class InputEvent_RotateCamera : IInputAnalogStart, IInputAnalogPerfom, IInputAnalogCancel {
    private IAnalogInputEventObservable _ObservableInputEvent;

    public InputEvent_RotateCamera(IAnalogInputEventObservable observableInputEvent) {
        _ObservableInputEvent = observableInputEvent;
    }

    public void AnalogInputEventStart(Vector2 value) {
        /*
         * @Desc: Captuers the inital change in the analog stick assigned to the input event RotateCamera and notifies all watchers about the change
         * @Param: Vector2 value - This parameter represents the current position of the analog stick on the user's controller.
        */
        _ObservableInputEvent.Notify(value); //Update watchers on change in analoge stick position
    }

    public void AnalogInputEventPerform(Vector2 value) {
        /*
         * @Desc: Captuers all additional changes in the analog stick assigned to the input event RotateCamera and notifies all watchers about the change
         * @Param: Vector2 value - This parameter represents the current position of the analog stick on the user's controller.
         * @NOTE: If the stick is held in place for a certain period of time, this method will not be called until its position is changed
        */
        _ObservableInputEvent.Notify(value); //Update watchers on change in analoge stick position
    }

    public void AnalogInputEventCancel() {
        /*
         * @Desc: Notifies all watchers that the analog stick assigned to the input event RotateCamera has returned to its resting position
        */
        _ObservableInputEvent.Notify(Vector2.zero); //Update watchers on change in analoge stick position
    }
}
