using System.Collections.Generic;

public class HoldInputEventObservable : IHoldInputEventObservable, IHoldInputEventAddObserver {
    private List<IHoldInputEventObserver> _Watchers;

    public HoldInputEventObservable() {
        _Watchers = new List<IHoldInputEventObserver>();
    }

    public void AddObserver(IHoldInputEventObserver watcher) {
        /*
         * @Desc: Takes an external classes and adds it to the list of watchers/observers
         * @Param: IHoldInputEventObserver watcher - This parameter represents the new external class that will be added to the list of watchers/observers
        */
        _Watchers.Add(watcher);
    }

    public void Notify(float holdTime) {
        /*
         * @Desc: Takes all the registered watchers/observers and notifies them about a partiulare change in the observable class
         * @Param: float holdTime - This parameter represents the time the button has been held down and will be passed to the watchers/observers
        */
        foreach (IHoldInputEventObserver watcher in _Watchers) {
            watcher.Update(holdTime);
        }
    }
}
