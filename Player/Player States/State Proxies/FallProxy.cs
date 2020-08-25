public class FallProxy : IDynamicProxy, IStateProxy {
    private readonly PlayerState _StatePlayer;
    public FallProxy(PlayerState playerState) {
        _StatePlayer = playerState;
    }

    public void ActiveProxy() {
        _StatePlayer.AddActiveProxy(this);
    }

    public void DeactivateProxy() {
        _StatePlayer.RemoveInactiveProxy(this);
        RetractRequest();
    }

    public void SendRequest() {
        _StatePlayer.Fall();
    }

    public void RetractRequest() {
        _StatePlayer.CancelFall();
    }
}
