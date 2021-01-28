public class FallState : APlayerState {
    public FallState(IState playerState) {
        StatePlayer = playerState;
    }

    public override void ExecuteStateEvent(IEventManager playerEvents) {
        playerEvents.FallEvent();
    }

    public override void Crouch() {
        StatePlayer.ChangeState(StatePlayer.StateCrouchFall());
    }

    public override void Walk() {
        StatePlayer.ChangeState(StatePlayer.StateAirMoveFall());
    }

    public override void CancelFall() {
        StatePlayer.ChangeState(StatePlayer.StateIdle());
    }
}
