public class State_Sprint : AState{
    public State_Sprint(PlayerStateController stateController) {
        _StateController = stateController;
    }

    public override void ExecuteStateEvent(PlayerEventController eventController) {
        eventController.TransitionToSprintEvent();
    }

    public override void CancelSprint() {
        _StateController.ChangeState(_StateController.GetWalkState());
    }

    public override void CancelWalk() {
        _StateController.ChangeState(_StateController.GetIdleState());
    }
}
