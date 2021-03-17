public class State_CrouchWalk : AState {
    public State_CrouchWalk(PlayerStateController stateController) {
        _StateController = stateController;
    }

    public override void ExecuteStateEvent(PlayerEventController eventController) {
        eventController.TransitionToNewEvent(eventController.GetCrouchWalkEvent());
    }

    public override void CancelCrouch() {
        _StateController.ChangeState(_StateController.GetWalkState());
    }

    public override void CancelWalk() {
        _StateController.ChangeState(_StateController.GetCrouchState());
    }

    public override void Sprint() {
        _StateController.ChangeState(_StateController.GetSprintState());
    }
}
