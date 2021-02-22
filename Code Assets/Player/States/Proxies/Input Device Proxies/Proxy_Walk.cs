public class Proxy_Walk : IDynamicProxies, IInputProxies  {
    private PlayerStateController _StateController;
    private Mediator_Proxies _ProxyMediator;
    private bool _InputActive;
    
    public Proxy_Walk(PlayerStateController stateController, Mediator_Proxies proxyMediator) {
        _StateController = stateController;
        _ProxyMediator = proxyMediator;
        _InputActive = false;
    }

    public void InputActive() {
        /**
         * @desc The input for this proxy is active 
        */
        _InputActive = true;
        CheckActivation();
    }

    public void InputInactive() {
        /**
         * @desc The input for this proxy is no longer active
        */
        _InputActive = false;
        CheckActivation();
    }

    public void CheckActivation() {
        /**
          * @desc Ensure this proxy is active/inactive as its internal parms changes and external parameters change as well
        */
        if (_InputActive) {
            SendRequest();
        } else {
            RetractRequest();
        }
    }

    public void SendRequest() {
        /**
          * @desc Tell the current state that it should transition to a walking state if such a path existed in the state machine
        */
        _StateController.GetActiveState().Walk();
    }

    public void RetractRequest() {
        /**
          * @desc Tell the current state that it should transition out of a walking state if such a path existed in the state machine 
        */
        _ProxyMediator.KillSprintProxy(); //Send a cancel request to the sprint proxy when the player has stopped moving
        _StateController.GetActiveState().CancelWalk();
    }
}
