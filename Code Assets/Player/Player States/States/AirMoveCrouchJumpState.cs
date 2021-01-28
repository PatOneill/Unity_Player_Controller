public class AirMoveCrouchJumpState : APlayerState {
    public AirMoveCrouchJumpState(IState playerState) {
        StatePlayer = playerState;
    }

    public override void ExecuteStateEvent(IEventManager playerEvents) {
        playerEvents.AirMoveCrouchJumpEvent();
    }

    public override void CancelWalk() {
        StatePlayer.ChangeState(StatePlayer.StateCrouchJump());
    }

    public override void CancelCrouch() {
        StatePlayer.ChangeState(StatePlayer.StateAirMoveJump());
    }

    public override void CancelFall() {
        StatePlayer.ChangeState(StatePlayer.StateCrouchWalk());
    }

    public override void CancelJump() {
        StatePlayer.ChangeState(StatePlayer.StateAirMoveCrouchFall());
    }
}
