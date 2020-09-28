public interface IInputProxyToggle : IStateProxyOnOff {
    void ProxyCancelToggle();
    ICommandToggle GetCommand();
}
