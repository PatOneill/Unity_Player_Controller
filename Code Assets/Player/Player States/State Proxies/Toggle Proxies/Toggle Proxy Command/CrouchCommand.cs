public class CrouchCommand : ICommandToggle {
    private IToggleInput _CrouchInput;

    public CrouchCommand() {
        
    }

    public void SetInput(IToggleInput input) {
        _CrouchInput = input;
    }

    public void ExecuteCommand() {
        _CrouchInput.CancelMessageFromProxy();
    }
}
