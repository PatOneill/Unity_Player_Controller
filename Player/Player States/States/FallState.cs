using UnityEngine;

public class FallState : APlayerState {
    public FallState(PlayerState playerState) {
        StatePlayer = playerState;
    }

    public override void ExecuteStateEvent(PlayerEvent playerEvents) {
        playerEvents.FallEvent();
    }

    public override void Walk() {
        StatePlayer.ChangeState(StatePlayer.StateAirMove);
    }

    public override void CancelFall() {
        StatePlayer.ChangeState(StatePlayer.StateIdle);
    }
}
