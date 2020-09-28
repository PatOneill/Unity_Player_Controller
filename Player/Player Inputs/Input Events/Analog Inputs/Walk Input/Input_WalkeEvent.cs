using UnityEngine;

public class Input_WalkeEvent : IAnalogInput {
    private readonly IAnalogInputObservable _ObserverController;
    private IStateProxyOnOff _ProxyWalk;

    public Input_WalkeEvent(IStateProxyOnOff walkProxy) {
        _ObserverController = new Input_AnalogObservable();
        _ProxyWalk = walkProxy;
    }

    public void AnalogStart(Vector2 direction) {
        _ObserverController.Notify(direction); //Notify all observers that the analog input from walk has changed
        _ProxyWalk.ProxyOn(); //Inform the walk state proxy that the player wants to enter the walking state
    }

    public void AnalogPerform(Vector2 direction) {
        _ObserverController.Notify(direction); //Notify all observers that the analog input from walk has changed
    }

    public void AnalogCancel() {
        _ObserverController.Notify(Vector2.zero); //Notify all observers that the analog input from walk has changed
        _ProxyWalk.ProxyOff(); //Inform the walk state proxy that the player wants to leave the walking state
    }

    public IAnalogInputObservable GetObservable() {
        return _ObserverController; //Used for adding Observers
    }
}
