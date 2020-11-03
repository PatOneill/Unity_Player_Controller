public interface IStateProxyInput {
    IInputProxyToggle ProxyCrouch();
    IInputProxyToggle ProxySprint();
    IAnalogInputObserver ProxySprintObserver();
    IStateProxyOnOff ProxyWalk();
    IStateProxyOnOff ProxyFall();
    IStateProxyOn ProxyJump();
    IStateProxyOff ProxyJumpPhysics();
}
