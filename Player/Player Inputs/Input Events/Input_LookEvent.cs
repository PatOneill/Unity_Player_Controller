using System.Collections.Generic;
using UnityEngine;

public class Input_LookEvent : IInputObservable {
    private IDynamicProxy _ProxyLook;
    private List<IInputObserver> _Watchers;

    public Input_LookEvent(IDynamicProxy lookProxy) {
        _ProxyLook = lookProxy;
        _Watchers = new List<IInputObserver>();
    }

    public void LookStart(Vector2 direction) {
        Notify(direction);
        _ProxyLook.ActiveProxy();
    }

    public void LookPerformed(Vector2 direction) {
        Notify(direction);
    }

    public void LookCanceled() {
        _ProxyLook.DeactivateProxy();
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
