public class AirMoveFallState : APlayerState {
    public AirMoveFallState(IState playerState) {
        StatePlayer = playerState;
    }
    public override void ExecuteStateEvent(IEventManager playerEvents) {
        playerEvents.AirMoveFallEvent();
    }

    public override void CancelWalk() {
        StatePlayer.ChangeState(StatePlayer.StateFall());
    }

    public override void Crouch() {
        StatePlayer.ChangeState(StatePlayer.StateAirMoveCrouchFall());
    }

    public override void CancelFall() {
        StatePlayer.ChangeState(StatePlayer.StateWalk());
    }
}
