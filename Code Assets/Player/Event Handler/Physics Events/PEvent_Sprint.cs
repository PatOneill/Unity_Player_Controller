public class PEvent_Sprint {
    private PlayerPhysicsController _PhysicsControllerPlayer;
    public PEvent_Sprint(PlayerPhysicsController playerPhysicsController) {
        _PhysicsControllerPlayer = playerPhysicsController;
    }

    public void ExecutePhysicsEvent(float sprintAcceleration) {
        /**
         * @desc Takes the player's rigidbody and applys the sprinting physics event causing the player's rigidbody to move horizontally
         * @parm float $sprintAcceleration - The speed at which the player will accelerate
        */
        _PhysicsControllerPlayer.MovePlayer(sprintAcceleration);
    }
}
