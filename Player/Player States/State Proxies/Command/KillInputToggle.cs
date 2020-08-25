public class KillInputToggle : AToogleCommand {
    private IToggleInput _InputToggle;

    public KillInputToggle() {
        _InputToggle = null;
    }

    public IToggleInput InputToggle { set => _InputToggle = value; }

    public override void KillToggle() {
        _InputToggle.KillToggle();
    }
}
