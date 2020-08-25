public abstract class AProxyMediator {
    protected IToggleInputProxy SprintToggleProxy;
    //protected IToggleInputProxy _CrouchToggleProxy;

    public void KillSprintToggle() {
        SprintToggleProxy.KillToggle();
    }
}
