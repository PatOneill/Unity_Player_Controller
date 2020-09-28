public class AirMoveJumpState : APlayerState {
    public AirMoveJumpState(IState playerState) {
        StatePlayer = playerState;
    }

    public override void ExecuteStateEvent(IEventManager playerEvents) {
        playerEvents.AirMoveJumpEvent();
    }

    public override void CancelWalk() {
        StatePlayer.ChangeState(StatePlayer.StateJump());
    }

    public override void Crouch() {
        StatePlayer.ChangeState(StatePlayer.StateAirMoveCrouchJump());
    }

    public override void CancelFall() {
        StatePlayer.ChangeState(StatePlayer.StateWalk());
    }

    public override void CancelJump() {
        StatePlayer.ChangeState(StatePlayer.StateAirMoveFall());
    }
}
