using UnityEngine;

public class AirMoveState : APlayerState {
    public AirMoveState(PlayerState playerState) {
        StatePlayer = playerState;
    }

    public override void ExecuteStateEvent(PlayerEvent playerEvent) {
        playerEvent.AirMoveEvent();
    }

    public override void CancleWalk() {
        StatePlayer.ChangeState(StatePlayer.StateFall);
    }

    public override void CancelFall() {
        StatePlayer.ChangeState(StatePlayer.StateWalk);
    }
}
