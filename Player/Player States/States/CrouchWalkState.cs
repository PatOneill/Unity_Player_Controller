public class CrouchWalkState : APlayerState {
    public CrouchWalkState(IState playerState) {
        StatePlayer = playerState;
    }

    public override void ExecuteStateEvent(IEventManager playerEvent) {
        playerEvent.CrouchWalkEvent();
    }

    public override void CancelCrouch() {
        StatePlayer.ChangeState(StatePlayer.StateWalk());
    }

    public override void Sprint() {
        StatePlayer.ChangeState(StatePlayer.StateSprint());
    }

    public override void CancelWalk() {
        StatePlayer.ChangeState(StatePlayer.StateCrouch());
    }

    public override void Jump() {
        StatePlayer.ChangeState(StatePlayer.StateWalk());
    }

    public override void Fall() {
        StatePlayer.ChangeState(StatePlayer.StateAirMoveCrouchFall());
    }
}
