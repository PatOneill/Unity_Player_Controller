using UnityEngine;

public class WalkState : APlayerState {
    public WalkState(IState playerState) {
        StatePlayer = playerState;
    }

    public override void ExecuteStateEvent(IEventManager playerEvent) {
        playerEvent.WalkEvent();
    }

    public override void CancelWalk() {
        StatePlayer.ChangeState(StatePlayer.StateIdle());
    }

    public override void Sprint() {
        StatePlayer.ChangeState(StatePlayer.StateSprint());
    }

    public override void Fall() {
        StatePlayer.ChangeState(StatePlayer.StateFall());
    }

    public override void Crouch() {
        StatePlayer.ChangeState(StatePlayer.StateCrouchWalk());
    }

    public override void Jump() {
        StatePlayer.ChangeState(StatePlayer.StateJump());
    }
}
