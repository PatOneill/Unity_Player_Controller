public class State_Walk : AState {

    public State_Walk(PlayerStateController stateController) {
        _StateController = stateController;
    }

    public override void ExecuteStateEvent(PlayerEventController eventController) {
        eventController.TransitionToNewEvent(eventController.GetWalkEvent());
    }

    public override void CancelWalk() {
        _StateController.ChangeState(_StateController.GetIdleState());
    }

    public override void Sprint() {
        _StateController.ChangeState(_StateController.GetSprintState());
    }

    public override void Crouch() {
        _StateController.ChangeState(_StateController.GetCrouchWalk());
    }
}
