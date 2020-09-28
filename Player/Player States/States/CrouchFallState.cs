public class CrouchFallState : APlayerState {
    public CrouchFallState(IState playerState) {
        StatePlayer = playerState;
    }

    public override void ExecuteStateEvent(IEventManager playerEvents) {
        throw new System.NotImplementedException();
    }

    public override void CancelFall() {
        StatePlayer.ChangeState(StatePlayer.StateCrouch());
    }

    public override void Walk() {
        StatePlayer.ChangeState(StatePlayer.StateAirMoveCrouchFall());
    }

    public override void CancelCrouch() {
        StatePlayer.ChangeState(StatePlayer.StateFall());
    }

    public override void Sprint() {
        StatePlayer.ChangeState(StatePlayer.StateFall());
    }

}
