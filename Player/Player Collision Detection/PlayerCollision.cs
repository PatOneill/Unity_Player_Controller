using UnityEngine;

public class PlayerCollision {
    private readonly GroundCheck _CheckGround;

    public GroundCheck CheckGround => _CheckGround;

    public PlayerCollision(Transform playerTransform, PlayerState playerState) {
        _CheckGround = new GroundCheck(playerTransform, playerState.ProxyFall);
    }

    public void GroundDetection() {
        _CheckGround.CheckForGround();
    }
}
