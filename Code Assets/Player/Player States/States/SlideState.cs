public class SlideState : APlayerState {
    public SlideState(IState playerState) {
        StatePlayer = playerState;
    }

    public override void ExecuteStateEvent(IEventManager playerEvent) {
        playerEvent.SlideEvent();
    }

    public override void Sprint() {
        StatePlayer.ChangeState(StatePlayer.StateSprint());
    }

    public override void CancelCrouch() {
        StatePlayer.ChangeState(StatePlayer.StateIdle());
    }

    public override void Jump() {
        StatePlayer.ChangeState(StatePlayer.StateJump());
    }

    public override void Fall() {
        StatePlayer.ChangeState(StatePlayer.StateFall());
    }
}
