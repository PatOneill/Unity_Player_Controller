using System.Xml;

public class SprintProxy : IDynamicProxy, IStateProxy, IToggleInputProxy {
    private KillInputToggle _KillSprintToggle;
    private readonly PlayerState _StatePlayer;

    public KillInputToggle KillSprintToggle { get => _KillSprintToggle; set => _KillSprintToggle = value; }

    public SprintProxy(PlayerState playerState) {
        _StatePlayer = playerState;
        _KillSprintToggle = new KillInputToggle();
    }

    public void ActiveProxy() {
        _StatePlayer.AddActiveProxy(this);
    }

    public void DeactivateProxy() {
        _StatePlayer.RemoveInactiveProxy(this);
        RetractRequest();
    }

    public void SendRequest() {
        _StatePlayer.Sprint();
    }

    public void RetractRequest() {
        _StatePlayer.CancelSprint();
    }

    public void KillToggle() {
        DeactivateProxy();
        _KillSprintToggle.KillToggle(); //Send a message to Input_SprintEvent that the toggle effect is no longer active
    }
}
