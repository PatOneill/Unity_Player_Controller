public class GameMenuProxy : IStateProxyOnOff, IDynamicProxy {
    private readonly IStateProxy _StatePlayer;

    public GameMenuProxy(IStateProxy playerState) {
        _StatePlayer = playerState;
    }

    public void ProxyOn() {
        
    }

    public void ProxyOff() {
        
    }

    public void ActiveProxy() {
        throw new System.NotImplementedException();
    }

    public void CheckActivation() {
        throw new System.NotImplementedException();
    }

    public void DeactivateProxy() {
        throw new System.NotImplementedException();
    }

    public void RetractRequest() {
        throw new System.NotImplementedException();
    }

    public void SendRequest() {
        throw new System.NotImplementedException();
    }
}
