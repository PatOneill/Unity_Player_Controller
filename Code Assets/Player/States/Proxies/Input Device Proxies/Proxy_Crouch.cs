public class Proxy_Crouch : IDynamicProxies, IInputProxies, IProxyDependent {
    private PlayerStateController _StateController;
    private bool _InputActive;
    private bool _IsToggled;
    private bool _ToggleProxyActive;

    public Proxy_Crouch(PlayerStateController stateController) {
        _StateController = stateController;
        _InputActive = false;
        _IsToggled = true;
        _ToggleProxyActive = false;
    }

    public void InputActive() {
        /**
         * @desc The input for this proxy is active 
        */
        
        _InputActive = true;
        if (_IsToggled) { //Check to see if the input is set to toggoled
            _ToggleProxyActive = !_ToggleProxyActive; //Monitor whether the proxy's state is active or inactive
        }
        CheckActivation();
    }

    public void InputInactive() {
        /**
         * @desc The input for this proxy is inactive 
        */
        _InputActive = false;
        CheckActivation();
    }

    public void CheckActivation() {
        /**
          * @desc Ensure this proxy is active/inactive as its internal parms changes and external parameters change as well
        */
        if (_IsToggled) { //If player has set crouch to toggle, handle toggle crouch event
            if (_ToggleProxyActive) {
                SendRequest();
            } else {
                RetractRequest();
            }
        } else { //If player has set crouch to press and hold, handle crouch press and hold event
            if (_InputActive) {
                SendRequest();
            } else {
                RetractRequest();
            }
        }
    }

    public void SendRequest() {
        /**
          * @desc Tell the current state that it should transition to a crouching state if such a path existed in the state machine
        */
        _StateController.GetActiveState().Crouch();
    }

    public void RetractRequest() {
        /**
          * @desc Tell the current state that it should transition out of a crouching state if such a path existed in the state machine 
        */
        _StateController.GetActiveState().CancelCrouch();
    }

    public void ExternalProxyKill() {
        /**
          * @desc The crouch proxy is a proxy that depends on the inactiveness of other proxies, if said proxies are turned active, crouch proxy most become inactive
        */
        if (_ToggleProxyActive) { //Check to see if the user is toggle crouching before setting the proxy to be inactive
            _ToggleProxyActive = false;
        }
    }

    public void EnableToggleToCrouch() {
        /**
          * @desc Enable toggle to crouch
        */
        _IsToggled = true;
    }

    public void DisableToggleToCrouch() {
        /**
          * @desc Disable toggle to crouch and set _ToggleProxyActive to false
        */
        _IsToggled = false;
        _ToggleProxyActive = false; //If the player disables toggle to crouch while actively crouching, set _ToggleProxyActive to false to ensure first crouch active always causes the player to crouch if toggle to crouch is re-enabled
    }
}
