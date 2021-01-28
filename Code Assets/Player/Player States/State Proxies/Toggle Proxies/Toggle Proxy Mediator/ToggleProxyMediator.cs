public class ToggleProxyMediator : IToggleProxySprintMediator, IToggleProxyCrouchMediator {
    private IInputProxyToggle _ProxySprint;
    private IInputProxyToggle _ProxyCrouch;

    public IInputProxyToggle ProxySprint { set => _ProxySprint = value; }
    public IInputProxyToggle ProxyCrouch { set => _ProxyCrouch = value; }

    public ToggleProxyMediator() {
        _ProxySprint = null;
        _ProxyCrouch = null;
    }

    public void CancelSprintToggle() {
        _ProxySprint.ProxyCancelToggle(); //An external proxy state has informed the sprint proxy that it is no longer active
    }

    public void CancelCrouchToggle() {
        _ProxyCrouch.ProxyCancelToggle(); //An external proxy state has informed the sprint proxy that it is no longer active
    }
}
