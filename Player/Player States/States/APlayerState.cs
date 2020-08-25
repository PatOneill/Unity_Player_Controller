public abstract class APlayerState {
    protected PlayerState StatePlayer;

    public abstract void ExecuteStateEvent(PlayerEvent playerEvents);

    public virtual void Idle() {
        return;
    }

    public virtual void Walk() {
        return;
    }

    public virtual void CancleWalk() {
        return;
    }

    public virtual void Sprint() {
        return;
    }

    public virtual void CancelSprint() {
        return;
    }

    public virtual void Fall() {
        return;
    }

    public virtual void CancelFall() {
        return;
    }
}
