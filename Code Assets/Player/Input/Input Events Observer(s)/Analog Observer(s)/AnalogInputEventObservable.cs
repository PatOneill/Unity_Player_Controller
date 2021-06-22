using System.Collections.Generic;
using UnityEngine;

public class AnalogInputEventObservable : IAnalogInputEventObservable, IAnalogInputEventAddObserver, IAnalogInputEventRemoveObserver {
    private List<IAnalogInputEventObserver> _Watchers;

    public AnalogInputEventObservable() {
        _Watchers = new List<IAnalogInputEventObserver>();
    }

    public void AddObserver(IAnalogInputEventObserver watcher) {
        /*
         * @Desc: Takes an external classes and adds it to the list of watchers/observers
         * @Param: IAnalogInputEventObserver watcher - This parameter represents the new external class that will be added to the list of watchers/observers
        */
        _Watchers.Add(watcher);
    }

    public void RemoveObserver(IAnalogInputEventObserver watcher) {
        /*
         * @Desc: Takes an external classes and removes it to the list of watchers/observers
         * @Param: IAnalogInputEventObserver watcher - This parameter represents the new external class that will be removed to the list of watchers/observers
        */
        _Watchers.Remove(watcher);
    }

    public void Notify(Vector2 direction) {
        /*
         * @Desc: Takes all the registered watchers/observers and notifies them about a partiulare change in the observable class
         * @Param: Vector2 direction - This parameter represents the new location of the analog stick's position and will be passed to the watchers/observers
        */
        foreach (IAnalogInputEventObserver watcher in _Watchers) {
            watcher.Update(direction);
        }
    }
}
