using UnityEngine;

public interface IInputObservable {
    void AddObserver(IInputObserver watcher);
    void Notify(Vector2 direction);
}
