using UnityEngine;

public class CrouchState : APlayerState {
    public CrouchState(IState playerState) {
        StatePlayer = playerState;
    }

    public override void ExecuteStateEvent(IEventManager playerEvent) {
        playerEvent.CrouchEvent();
    }

    public override void CancelCrouch() {
        StatePlayer.ChangeState(StatePlayer.StateIdle());
    }

    public override void Sprint() {
        StatePlayer.ChangeState(StatePlayer.StateSprint());
    }

    public override void Walk() {
        StatePlayer.ChangeState(StatePlayer.StateCrouchWalk());
    }

    public override void Jump() {
        StatePlayer.ChangeState(StatePlayer.StateIdle());
    }
}
