public class Input_SprintEvent : IToggleInput {
    private SprintProxy _ProxySprint;
    private bool _IsToggled;

    public Input_SprintEvent(SprintProxy sprintProxy) {
        _IsToggled = false;
        _ProxySprint = sprintProxy;
        _ProxySprint.KillSprintToggle.InputToggle = this ;
    }

    public void SprintStart() {
        _IsToggled = !_IsToggled;
        if (_IsToggled) { //Check to see if the user is requesting to cancel sprint or activate sprint
            _ProxySprint.ActiveProxy(); //Inform the state proxy that the player wants to enter the sprinting state
        } else {
            _ProxySprint.DeactivateProxy(); //Inform the state proxy that the player wants to leave the sprinting state
        }
    }

    public void KillToggle() {
        _IsToggled = false; //Message from sprint proxy to set toggle false, as another state has overwritten the sprint state
    }
}
