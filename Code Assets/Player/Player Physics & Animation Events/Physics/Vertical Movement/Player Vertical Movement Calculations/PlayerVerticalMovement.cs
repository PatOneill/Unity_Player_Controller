using UnityEngine;

public class PlayerVerticalMovement : IPlayerJump, IPlayerFall, IPlayerHorizontalJump, IPlayerHorizontalFall {
    private PlayerPhysics _PhysicsPlayer;
    private Rigidbody _PlayerRigidbody;
    private Transform _PlayerTransform;
    private readonly IVerticalMovement _CeilingPhysics;
    private readonly float _FallSpeed;
    private readonly float _MaxFallSpeed;
    private readonly float _MidAirReduction;
    private readonly float _MinAirMoveSpeed;
    private readonly float _HorizontalDecayRate;

    public PlayerVerticalMovement(PlayerPhysics playerPhysics, Rigidbody playerRigidbody) {
        _PhysicsPlayer = playerPhysics;
        _PlayerRigidbody = playerRigidbody;
        _PlayerTransform = playerRigidbody.transform;
        _CeilingPhysics = _PhysicsPlayer.GetCeilingCheck();

        _FallSpeed = -4.9f;
        _MaxFallSpeed = -9.8f;
        _MidAirReduction = 4.0f;
        _MinAirMoveSpeed = 0.1f;
        _HorizontalDecayRate = 0.05f;
    }

    //Player is jumping with no horizontal velocity
    public void PlayerJumping() {
        
    }

    //Player is jumping with a horizontal velocity
    public void PlayerHorizontalJumping() {
        
    }

    //Player is falling with no horizontal velocity
    public void PlayerFalling() {
       
    }

    //Player is falling with a horizontal velocity
    public void PlayerHorizontalFalling() {
        
    }
}
