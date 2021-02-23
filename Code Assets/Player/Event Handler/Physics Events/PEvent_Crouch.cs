public class PEvent_Crouch {
    private PlayerPhysicsController _PhysicsControllerPlayer;

    public PEvent_Crouch(PlayerPhysicsController playerPhysicsController) {
        _PhysicsControllerPlayer = playerPhysicsController;
    }

    public void ExecutePhysicsEvent() {
        /**
         * @desc Forces the player's rigidbody to come to a complete stop
        */
        _PhysicsControllerPlayer.FullyStopMotion();
    }
}
