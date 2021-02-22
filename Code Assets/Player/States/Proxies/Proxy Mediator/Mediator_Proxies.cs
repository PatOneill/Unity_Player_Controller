public class Mediator_Proxies {
    private IProxyDependent _SprintProxy;

    public void SetSprintProxy(IProxyDependent sprintProxy) { _SprintProxy = sprintProxy; }

    public Mediator_Proxies() {
        _SprintProxy = null;
    }

    public void KillSprintProxy() {
        /**
          * @desc Send a message to the sprint proxy that an external proxy has made a request to set the sprint proxy to be inactive
        */
        _SprintProxy.ExternalProxyKill();
    }
}
