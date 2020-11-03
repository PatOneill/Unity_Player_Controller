public class JumpState : APlayerState {
    public JumpState(IState playerState) {
        StatePlayer = playerState;
    }

    public override void ExecuteStateEvent(IEventManager playerEvent) {
        playerEvent.JumpEvent();
    }

    public override void CancelJump() {
        StatePlayer.ChangeState(StatePlayer.StateFall());
    }

    public override void Walk() {
        StatePlayer.ChangeState(StatePlayer.StateAirMoveJump());
    }

    public override void Crouch() {
        StatePlayer.ChangeState(StatePlayer.StateCrouchJump());
    }
}
