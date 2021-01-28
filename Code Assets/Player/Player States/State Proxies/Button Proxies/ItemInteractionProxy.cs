using UnityEngine;

public class ItemInteractionProxy : IStateProxyOnOff, IDynamicProxy {
    private readonly IStateProxy _StatePlayer;
    private readonly PhysicsItemPickup _WorldItemInteractionDetection;
    private bool _IsInputActive;
    private bool _IsInteractionActive;

    public ItemInteractionProxy(IStateProxy playerState, PhysicsItemPickup itemDetection) {
        _StatePlayer = playerState;
        _WorldItemInteractionDetection = itemDetection;
        _IsInputActive = false;
    }

    public void ProxyOn() {
        _IsInputActive = true;
    }

    public void ProxyOff() {
        //Check to see if the user wants to reload a weapon
        CheckActivation();
        _IsInputActive = false;
    }

    public void CheckActivation() {
        _WorldItemInteractionDetection.ItemInteraction(); //Check to see if the user is attempting to pick up an item or open an item holder
    }

    public void ActiveProxy() {
        throw new System.NotImplementedException();
    }

    public void DeactivateProxy() {
        throw new System.NotImplementedException();
    }

    public void SendRequest() {
        throw new System.NotImplementedException();
    }

    public void RetractRequest() {
        throw new System.NotImplementedException();
    }
}
