using System.Collections.Generic;
using UnityEngine;

public class Input_AnalogObservable : IAnalogInputObservable {
    private List<IAnalogInputObserver> _Watchers;

    public Input_AnalogObservable() {
        _Watchers = new List<IAnalogInputObserver>();
    }

    public void AddObserver(IAnalogInputObserver watcher) {
        _Watchers.Add(watcher);
    }

    public void Notify(Vector2 direction) {
        foreach (IAnalogInputObserver watcher in _Watchers) {
            watcher.Update(direction);
        }
    }
}
