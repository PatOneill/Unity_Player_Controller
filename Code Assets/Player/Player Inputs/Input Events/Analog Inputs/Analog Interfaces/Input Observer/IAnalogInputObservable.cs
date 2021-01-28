using UnityEngine;

public interface IAnalogInputObservable {
    void AddObserver(IAnalogInputObserver watcher);
    void Notify(Vector2 direction);
}
