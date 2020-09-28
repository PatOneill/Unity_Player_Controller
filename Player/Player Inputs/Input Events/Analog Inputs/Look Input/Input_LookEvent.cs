using UnityEngine;

public class Input_LookEvent : IAnalogInput {
    private readonly IAnalogInputObservable _ObserverController;
    private readonly IStateProxyOnOff _ProxyLook;

    public Input_LookEvent(IStateProxyOnOff lookProxy) {
        _ObserverController = new Input_AnalogObservable();
        _ProxyLook = lookProxy;
    }

    public void AnalogStart(Vector2 direction) {
        _ProxyLook.ProxyOn();
        _ObserverController.Notify(Vector2.zero); //Notify all observers that the analog input from look has changed
    }

    public void AnalogPerform(Vector2 direction) {
        _ObserverController.Notify(direction); //Notify all observers that the analog input from look has changed
    }

    public void AnalogCancel() {
        _ProxyLook.ProxyOff();
        _ObserverController.Notify(Vector2.zero); //Notify all observers that the analog input from look has changed
    }

    public IAnalogInputObservable GetObservable() {
        return _ObserverController; //Used for adding Observers
    }

}
