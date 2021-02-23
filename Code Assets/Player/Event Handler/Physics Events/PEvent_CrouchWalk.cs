public class PEvent_CrouchWalk {
    private PlayerPhysicsController _PhysicsControllerPlayer;

    public PEvent_CrouchWalk(PlayerPhysicsController playerPhysicsController) {
        _PhysicsControllerPlayer = playerPhysicsController;
    }

    public void ExecutePhysicsEvent(float crouchWalkAccelaration) {
        /**
         * @desc Takes the player's rigidbody and applys the crouch walking physics event causing the player's rigidbody to move horizontally
         * @parm float $crouchWalkAccelaration - The speed at which the player will accelerate
        */
        _PhysicsControllerPlayer.MovePlayer(crouchWalkAccelaration);
    }
}
