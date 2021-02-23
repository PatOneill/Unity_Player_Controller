public class PEvent_Walk {
    private PlayerPhysicsController _PhysicsControllerPlayer;
    
    public PEvent_Walk(PlayerPhysicsController playerPhysicsController) {
        _PhysicsControllerPlayer = playerPhysicsController;
    }

    public void ExecutePhysicsEvent(float walkAcceleration) {
        /**
         * @desc Takes the player's rigidbody and applys the walking physics event causing the player's rigidbody to move horizontally
         * @parm float $walkAcceleration - The speed at which the player will accelerate
        */
        _PhysicsControllerPlayer.MovePlayer(walkAcceleration);
    }
}
