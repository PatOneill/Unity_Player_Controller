public abstract class APlayerState {
    protected IState StatePlayer;

    public abstract void ExecuteStateEvent(IEventManager playerEvents);

    public virtual void Idle() {
        return;
    }

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

    public virtual void Fall() {
        return;
    }

    public virtual void CancelFall() {
        return;
    }

    public virtual void Crouch() {
        return;
    }

    public virtual void CancelCrouch() {
        return;
    }

    public virtual void Jump() {
        return;
    }

    public virtual void CancelJump() {
        return;
    }
}
