using UnityEngine;

public class Input_LeftAnalog {
    private IInputObservable _ObserverController;
    private IInputProxies _WalkProxy;
    private IInputProxies _SprintProxy;
    public Input_LeftAnalog(IInputProxies walkProxy, IInputProxies sprintProxy) {
        _ObserverController = new Input_ObservableEvents();
        _WalkProxy = walkProxy;
        _SprintProxy = sprintProxy;
    }

    public void GamePlay_InputStartWalk(Vector2 analogMovement) {
        /**
          * @desc Inform the walk proxy and the observers that the left stick is starting to be moved
          * @parm Vector2 $analogMovement - The current position of the analog stick (Note: ranges from (1,1) to (-1, -1))
        */
        _WalkProxy.InputActive();
        _ObserverController.Notify(analogMovement);
    }

    public void GamePlay_InputUpdateWalk(Vector2 analogMovement) {
        /**
          * @desc Inform the observers that the left stick is still moving (Note: if the player hold the analog stick still at a position not at (0,0) for an extended period of time, then this method will stop being called unitl a change is made)
          * @parm Vector2 $analogMovement - The current position of the analog stick (Note: ranges between  (1,1) to (-1, -1))
        */
        _ObserverController.Notify(analogMovement);
    }

    public void GamePlay_InputEndWalk() {
        /**
          * @desc Inform the walk proxy and observers that the player is no longer actively moving/holding the left analog stick in a position other than (0,0)
        */
        _WalkProxy.InputInactive();
        _ObserverController.Notify(Vector2.zero); //Notify all observers that the left stick is no longer being moved
    }

    public void GamePlay_InputStartSprint() {
        /**
          * @desc Inform the sprint proxy that the left stick  has been pressed down
        */
        _SprintProxy.InputActive();
    }

    public void GamePlay_InputEndSprint() {
        /**
          * @desc Inform the sprint proxy that the player is no longer being held down the left stick
        */
        _SprintProxy.InputInactive();
    }

    public IInputObservable GetLeftAnalogObservable() {
        /**
          * @desc Allows new observers to subscribe to see how the left analog stick's movement value is changed
        */
        return _ObserverController;
    }
}
