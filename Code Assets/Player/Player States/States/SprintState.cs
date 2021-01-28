public class SprintState : APlayerState {
    public SprintState(IState playerState) {
        StatePlayer = playerState;
    }

    public override void ExecuteStateEvent(IEventManager playerEvent) {
        playerEvent.SprintEvent();
    }

    public override void CancelWalk() {
        StatePlayer.ChangeState(StatePlayer.StateIdle());
    }

    public override void CancelSprint() {
        StatePlayer.ChangeState(StatePlayer.StateWalk());
    }

    public override void Fall() {
        StatePlayer.ChangeState(StatePlayer.StateAirMoveFall());
    }

    public override void Jump() {
        StatePlayer.ChangeState(StatePlayer.StateJump());
    }

    public override void Crouch() {
        //StatePlayer.ChangeState(StatePlayer.StateSlide());
    }
}
