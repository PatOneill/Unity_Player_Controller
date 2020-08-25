using System.Collections.Generic;
using UnityEngine;

public class Input_WalkeEvent : IInputObservable{
    private List<IInputObserver> _Watchers;
    private IDynamicProxy _ProxyWalk;

    public Input_WalkeEvent(IDynamicProxy walkProxy) {
        _Watchers = new List<IInputObserver>();
        _ProxyWalk = walkProxy;
    }

    public void WalkStart(Vector2 direction) {
        Notify(direction);
        _ProxyWalk.ActiveProxy(); //Inform the state proxy that the player wants to enter the walking state
    }

    public void WalkPerformed(Vector2 direction) {
        Notify(direction);
    }

    public void WalkCanceled() {
        Notify(Vector2.zero);
        _ProxyWalk.DeactivateProxy(); //Inform the state proxy that the player wants to leave the walking state
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
