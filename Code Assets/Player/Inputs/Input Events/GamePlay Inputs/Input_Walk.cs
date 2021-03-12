using UnityEngine;

public class Input_Walk {
    private IInputObservable _ObserverController;
    private IInputProxies _WalkProxy;

    public Input_Walk(IInputProxies walkProxy) {
        _ObserverController = new Input_ObservableEvents();
        _WalkProxy = walkProxy;
    }

    public void InputStart(Vector2 analogMovement) {
        /**
          * @desc Inform the walk proxy and the observers that the left stick is starting to be moved
          * @parm Vector2 $analogMovement - The current position of the analog stick (Note: ranges from (1,1) to (-1, -1))
        */
        _WalkProxy.InputActive();
        _ObserverController.Notify(analogMovement);
    }

    public void InputUpdate(Vector2 analogMovement) {
        /**
          * @desc Inform the observers that the left stick is still moving (Note: if the player hold the analog stick still at a position not at (0,0) for an extended period of time, then this method will stop being called unitl a change is made)
          * @parm Vector2 $analogMovement - The current position of the analog stick (Note: ranges between  (1,1) to (-1, -1))
        */
        _ObserverController.Notify(analogMovement);
    }

    public void InputEnd() {
        /**
          * @desc Inform the walk proxy and observers that the player is no longer actively moving/holding the left analog stick in a position other than (0,0)
        */
        _WalkProxy.InputInactive();
        _ObserverController.Notify(Vector2.zero); //Notify all observers that the left stick is no longer being moved
    }

    public IInputObservable GetLeftAnalogObservable() {
        /**
          * @desc Allows new observers to subscribe to see how the left analog stick's movement value is changed
        */
        return _ObserverController;
    }
}
