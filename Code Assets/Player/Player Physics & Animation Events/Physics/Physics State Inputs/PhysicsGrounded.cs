using UnityEngine;

public class PhysicsGrounded {
    private IStateProxyOnOff _ProxyFall;
    private readonly Transform _PlayerTransform;
    private readonly PlayerPhysics _PhysicsPlayer;
    private Collider[] _ColliderHits;
    private readonly LayerMask _GroundCollisionLayers;
    private readonly Vector3 _GroundCheckSize;
    private Vector3 _GroundLocation;
    private bool _IsGrounded;

    public PhysicsGrounded(PlayerPhysics playerPhysics, Transform playerTransform) {
        _ProxyFall = null;
        _PlayerTransform = playerTransform;
        _PhysicsPlayer = playerPhysics;
        _ColliderHits = new Collider[] { };
        _GroundCollisionLayers = LayerMask.GetMask("Ground");
        _GroundCheckSize = new Vector3(0.025f, 0.25f, 0.025f);
        _GroundLocation = Vector3.zero;
        _IsGrounded = true;

    }

    public void CheckGround() {
    
    }

    public void SetFallProxy(IStateProxyOnOff proxy) {
        _ProxyFall = proxy;
    }
}
