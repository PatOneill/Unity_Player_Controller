public class IdleState : APlayerState {
    public IdleState(PlayerState playerState) {
        StatePlayer = playerState;
    }

    public override void ExecuteStateEvent(PlayerEvent playerEvent) {
        playerEvent.IdleEvent();
    }

    public override void Walk() {
        StatePlayer.ChangeState(StatePlayer.StateWalk);
    }

    public override void Fall() {
        StatePlayer.ChangeState(StatePlayer.StateFall);
    }
}
