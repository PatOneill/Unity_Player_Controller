public class SprintState : APlayerState {
    public SprintState(PlayerState playerState) {
        StatePlayer = playerState;
    }

    public override void ExecuteStateEvent(PlayerEvent playerEvent) {
        playerEvent.SprintEvent();
    }

    public override void CancleWalk() {
        StatePlayer.ChangeState(StatePlayer.StateIdle);
    }

    public override void CancelSprint() {
        StatePlayer.ChangeState(StatePlayer.StateWalk);
    }

    public override void Fall() {
        StatePlayer.ChangeState(StatePlayer.StateFall);
    }
}
