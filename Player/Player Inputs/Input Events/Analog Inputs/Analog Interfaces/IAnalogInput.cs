using UnityEngine;

public interface IAnalogInput {
    void AnalogStart(Vector2 direction);
    void AnalogPerform(Vector2 direction);
    void AnalogCancel();
    IAnalogInputObservable GetObservable();
}
