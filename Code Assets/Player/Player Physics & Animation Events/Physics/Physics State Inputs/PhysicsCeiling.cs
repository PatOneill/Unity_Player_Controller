using UnityEngine;

public class PhysicsCeiling : IVerticalMovement {
    private readonly PlayerPhysics _PhysicsPlayer;
    private readonly Vector3 _CeilingCheckSize;
    private readonly Transform _PlayerTransform;
    private readonly LayerMask _CeilingCollisionLayers;
    private Collider[] _ColliderHits;
    private IStateProxyOff _ProxyJump;

    public PhysicsCeiling(PlayerPhysics playerPhysics, Transform playerTransform) {
        _ProxyJump = null;
        _PhysicsPlayer = playerPhysics;
        _PlayerTransform = playerTransform;
        _CeilingCheckSize = new Vector3(0.1f, 0.1f, 0.1f);
        _CeilingCollisionLayers = LayerMask.GetMask("Ceiling");
        _ColliderHits = new Collider[] { };
    }

    public bool CheckCeiling(Vector3 location) {
        return true;
    }

    public void VelocityCheck() {

    }

    public void SetJumpProxy(IStateProxyOff proxy) {
        _ProxyJump = proxy;
    }
}
