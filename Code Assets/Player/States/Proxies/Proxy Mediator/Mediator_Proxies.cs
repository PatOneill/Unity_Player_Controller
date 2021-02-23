public class Mediator_Proxies {
    private IProxyDependent _SprintProxy;
    private IProxyDependent _CrouchProxy;

    public void SetSprintProxy(IProxyDependent sprintProxy) { _SprintProxy = sprintProxy; }
    public void SetCrouchProxy(IProxyDependent crouchProxy) { _CrouchProxy = crouchProxy; }

    public Mediator_Proxies() {
        _SprintProxy = null;
        _CrouchProxy = null;
    }

    public void KillSprintProxy() {
        /**
          * @desc Send a message to the sprint proxy that an external proxy has made a request to set the sprint proxy to be inactive
        */
        _SprintProxy.ExternalProxyKill();
    }

    public void KillCrouchProxy() {
        /**
          * @desc Send a message to the crouch proxy that an external proxy has made a request to set the crouch proxy to be inactive
        */
        _CrouchProxy.ExternalProxyKill();
    }
}
