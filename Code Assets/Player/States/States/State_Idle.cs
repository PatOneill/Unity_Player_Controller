public class State_Idle : AState {
    public State_Idle(PlayerStateController stateController) {
        _StateController = stateController;
    }

    public override void ExecuteStateEvent(PlayerEventController eventController) {
        eventController.TransitionToNewEvent(eventController.GetIdleEvent());
    }

    public override void Walk() {
        _StateController.ChangeState(_StateController.GetWalkState());
    }

    public override void Crouch() {
        _StateController.ChangeState(_StateController.GetCrouchState());
    }
}