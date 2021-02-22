using System.Collections.Generic;
using UnityEngine;

public class Input_ObservableEvents : IInputObservable {
    private List<IInputObserver> _Watchers;

    public Input_ObservableEvents() {
        _Watchers = new List<IInputObserver>();
    }

    public void AddObserver(IInputObserver watcher) {
        _Watchers.Add(watcher);
    }

    public void Notify(Vector2 direction) {
        foreach (IInputObserver watcher in _Watchers) {
            watcher.Update(direction);
        }
    }
}
