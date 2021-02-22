public abstract class AState {
    protected PlayerStateController _StateController;

    public abstract void ExecuteStateEvent(PlayerEventController eventController);

    public virtual void Walk() {
        return;
    }

    public virtual void CancelWalk() {
        return;
    }

    public virtual void Sprint() {
        return;
    }

    public virtual void CancelSprint() {
        return;
    }
}
