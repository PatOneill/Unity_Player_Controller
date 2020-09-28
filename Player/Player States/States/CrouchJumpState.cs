public class CrouchJumpState : APlayerState {
    public CrouchJumpState (IState playerState) {
        StatePlayer = playerState;
    }

    public override void ExecuteStateEvent(IEventManager playerEvent) {
        playerEvent.CrouchJumpEvent();
    }

    public override void CancelJump() {
        StatePlayer.ChangeState(StatePlayer.StateCrouchFall());
    }

    public override void Fall() {
        StatePlayer.ChangeState(StatePlayer.StateCrouchFall());
    }

    public override void CancelFall() {
        StatePlayer.ChangeState(StatePlayer.StateCrouch());
    }

    public override void Walk() {
        StatePlayer.ChangeState(StatePlayer.StateAirMoveCrouchJump());
    }

    public override void CancelCrouch() {
        StatePlayer.ChangeState(StatePlayer.StateJump());
    }

    public override void Sprint() {
        StatePlayer.ChangeState(StatePlayer.StateJump());
    }
}
