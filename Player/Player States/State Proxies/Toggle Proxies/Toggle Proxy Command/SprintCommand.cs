public class SprintCommand : ICommandToggle {
    private IToggleInput _SprintToggle;
    public SprintCommand() {
        
    }

    public void SetInput(IToggleInput input) {
        _SprintToggle = input;
    }

    public void ExecuteCommand() {
        _SprintToggle.CancelMessageFromProxy();
    }
}
