public class Input_JumpEvent : IButtonReleaseInput {
    private readonly IStateProxyOn _ProxyJump;

    public Input_JumpEvent(IStateProxyOn jumpProxy) {
        _ProxyJump = jumpProxy;
    }

    public void ButtonStart() {
        _ProxyJump.ProxyOn();
    }
}
