public class WalkState : APlayerState {
    public WalkState(PlayerState playerState) {
        StatePlayer = playerState;
    }

    public override void ExecuteStateEvent(PlayerEvent playerEvent) {
        playerEvent.WalkEvent();
    }

    public override void CancleWalk() {
        StatePlayer.ChangeState(StatePlayer.StateIdle);
    }

    public override void Sprint() {
        StatePlayer.ChangeState(StatePlayer.StateSprint);
    }

    public override void Fall() {
        StatePlayer.ChangeState(StatePlayer.StateFall);
    }
}
