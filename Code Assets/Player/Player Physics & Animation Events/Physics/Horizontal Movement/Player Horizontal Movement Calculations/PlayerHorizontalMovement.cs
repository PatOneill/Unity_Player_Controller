using UnityEngine;

public class PlayerHorizontalMovement : IHorizontalMove {
    private readonly PlayerPhysics _PhysicsPlayer;
    private Rigidbody _PlayerRigidbody;
    private Transform _PlayerTransform;

    public PlayerHorizontalMovement(PlayerPhysics playerPhysics, Rigidbody playerRigidbody) {
        _PhysicsPlayer = playerPhysics;
        _PlayerRigidbody = playerRigidbody;
        _PlayerTransform = playerRigidbody.transform;
    }

    public void PlayerMoveHorizontally(in float acceleration, in float maxVelocity) {
        
    }

    #region Private Functions

    #endregion
}
