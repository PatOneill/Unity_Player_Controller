using UnityEngine;

public class PhysicsGrounded {
    private IStateProxyOnOff _ProxyFall;
    private readonly Transform _PlayerTransform;
    private readonly PlayerPhysics _PhysicsPlayer;
    private Collider[] _ColliderHits;
    private readonly LayerMask _GroundLayer;
    private readonly Vector3 _GroundCheckSize;
    private bool _IsGrounded;

    public PhysicsGrounded(PlayerPhysics playerPhysics, Transform playerTransform, LayerMask groundLayer, Vector3 groundCheckSize ) {
        _ProxyFall = null;
        _PlayerTransform = playerTransform;
        _PhysicsPlayer = playerPhysics;
        _ColliderHits = new Collider[] { };
        _GroundLayer = groundLayer;
        _GroundCheckSize = groundCheckSize;
        _IsGrounded = true;
    }

    public void CheckGround() {
        _ColliderHits = Physics.OverlapBox(_PlayerTransform.position, _GroundCheckSize, _PlayerTransform.rotation, _GroundLayer);
        if (_ColliderHits.Length > 0) {
            if (_IsGrounded) { return; } //Don't continuously call state controller with repetitive messages that the player is grounded
            _ProxyFall.ProxyOff(); //Player is grounded

            Vector3 resetYVelocity = _PhysicsPlayer.CurrentVelocity; //When the player hits the ground ensure that their y velocity is set to zero again
            resetYVelocity.y = 0.0f;
            _PhysicsPlayer.CurrentVelocity = resetYVelocity;

            _IsGrounded = true;
        } else {
            if (!_IsGrounded) { return; } //Don't continuously call state controller with repetitive messages that the player is falling
            _ProxyFall.ProxyOn(); //Player is not grounded
            _IsGrounded = false;
        }
    }

    public void SetFallProxy(IStateProxyOnOff proxy) {
        _ProxyFall = proxy;
    }
}
