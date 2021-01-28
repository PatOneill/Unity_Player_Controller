public class AirMoveCrouchFallState : APlayerState {
    public AirMoveCrouchFallState(IState playerState) {
        StatePlayer = playerState;
    }

    public override void ExecuteStateEvent(IEventManager playerEvents) {
        playerEvents.AirMoveCrouchFallEvent();
    }

    public override void CancelCrouch() {
        StatePlayer.ChangeState(StatePlayer.StateAirMoveFall());
    }

    public override void CancelFall() {
        StatePlayer.ChangeState(StatePlayer.StateCrouchWalk());
    }
}
