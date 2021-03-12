using UnityEngine;
public class Input_Look {
    private IInputObservable _ObserverController;
    private IInputProxies _LookProxy;
    public Input_Look(Proxy_Look lookProxy) {
        _ObserverController = new Input_ObservableEvents();
        _LookProxy = lookProxy;
    }

    public void InputStart(Vector2 analogMovement) {
        /**
          * @desc Inform the look proxy and the observers that the right stick is starting to be moved
          * @parm Vector2 $analogMovement - The current position of the analog stick (Note: ranges from (1,1) to (-1, -1))
        */
        _LookProxy.InputActive();
        _ObserverController.Notify(analogMovement);
    }

    public void InputUpdate(Vector2 analogMovement) {
        /**
          * @desc Inform the observers that the right stick is still moving (Note: if the player hold the analog stick still at a position not at (0,0) for an extended period of time, then this method will stop being called unitl a change is made)
          * @parm Vector2 $analogMovement - The current position of the analog stick (Note: ranges between  (1,1) to (-1, -1))
        */
        _ObserverController.Notify(analogMovement);
    }

    public void InputEnd() {
        /**
          * @desc Inform the look proxy and observers that the player is no longer actively moving/holding the right analog stick in a position other than (0,0)
        */
        _ObserverController.Notify(Vector2.zero);
        _LookProxy.InputInactive();
    }

    public IInputObservable GetRightAnalogObservable() {
        /**
          * @desc Allows new observers to subscribe to see how the right analog stick's movement value is changed
        */
        return _ObserverController;
    }
}
