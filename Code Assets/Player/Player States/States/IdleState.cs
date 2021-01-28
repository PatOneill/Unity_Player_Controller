public class IdleState : APlayerState {
    public IdleState(IState playerState) {
        StatePlayer = playerState;
    }

    public override void ExecuteStateEvent(IEventManager playerEvent) {
        playerEvent.IdleEvent();
    }

    public override void Walk() {
        StatePlayer.ChangeState(StatePlayer.StateWalk());
    }

    public override void Fall() {
        StatePlayer.ChangeState(StatePlayer.StateFall());
    }

    public override void Jump() {
        StatePlayer.ChangeState(StatePlayer.StateJump());
    }

    public override void Crouch() {
        StatePlayer.ChangeState(StatePlayer.StateCrouch());
    }
}
