public class LookProxy : IDynamicProxy {
    private PlayerCamera _PlayerCamer;
    public LookProxy(PlayerCamera playerCamera) {
        _PlayerCamer = playerCamera;
    }

    public void ActiveProxy() {
        _PlayerCamer.IsActive = true; //Update the players camera according to the player's analog stick
    }

    public void DeactivateProxy() {
        _PlayerCamer.IsActive = false;
    }
}
