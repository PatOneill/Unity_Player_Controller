public class PEvent_Idle {
    private PlayerPhysicsController _PhysicsControllerPlayer;
    public PEvent_Idle(PlayerPhysicsController playerPhysicsController) {
        _PhysicsControllerPlayer = playerPhysicsController;
    }

    public void ExecutePhysicsEvent() {
        _PhysicsControllerPlayer.FullyStopMotion();
    }
}
