public class LookProxy : IStateProxyOnOff {
    private PlayerCamera _PlayerCamer;
    public LookProxy(PlayerCamera playerCamera) {
        _PlayerCamer = playerCamera;
    }

    public void ProxyOn() {
        _PlayerCamer.IsActive = true; //Update the players camera according to the player's analog stick
    }

    public void ProxyOff() {
        _PlayerCamer.IsActive = false;
    }
}
