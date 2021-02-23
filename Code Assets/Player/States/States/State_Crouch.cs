public class State_Crouch : AState {
    public State_Crouch(PlayerStateController stateController) {
        _StateController = stateController;
    }

    public override void ExecuteStateEvent(PlayerEventController eventController) {
        eventController.TransitionToCrouchEvent();
    }

    public override void CancelCrouch() {
        _StateController.ChangeState(_StateController.GetIdleState());
    }

    public override void Walk() {
        _StateController.ChangeState(_StateController.GetCrouchWalk());
    }
}
