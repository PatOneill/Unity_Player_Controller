using UnityEngine;

public class PhysicsCeiling : IVerticalMovement {
    private readonly PlayerPhysics _PhysicsPlayer;
    private readonly float _HeadOffset;
    private readonly Vector3 _CeilingCheckSize;
    private readonly Transform _PlayerTransform;
    private readonly LayerMask _CeilingLayers;
    private Collider[] _ColliderHits;
    private IStateProxyOff _ProxyJump;

    public PhysicsCeiling(PlayerPhysics playerPhysics, Transform playerTransform, LayerMask ceilingLayer, Vector3 ceilCheckSize, float headOffSet) {
        _ProxyJump = null;
        _PhysicsPlayer = playerPhysics;
        _PlayerTransform = playerTransform;
        _CeilingCheckSize = ceilCheckSize;
        _CeilingLayers = ceilingLayer;
        _ColliderHits = new Collider[] { };
        _HeadOffset = headOffSet;
    }

    public bool CheckCeiling(Vector3 location) {
        location.y += _HeadOffset;
        _ColliderHits = Physics.OverlapBox(location, _CeilingCheckSize, _PlayerTransform.rotation, _CeilingLayers);
        if (_ColliderHits.Length == 0) {
            return false; //The player is not colliding with some physics object at the desired location
        } else {
            Vector2 currentVelocity = _PhysicsPlayer.CurrentVelocity;
            currentVelocity.y = 0.0f; //Set y velocity to zero as the plater has hit a ceiling 
            _PhysicsPlayer.CurrentVelocity = currentVelocity;
            _ProxyJump.ProxyOff(); //End jump state as the player has hit a ceiling 
            return true;
        }
    }

    public void VelocityCheck() {
        if(_PhysicsPlayer.CurrentVelocity.y < 0.0f){
            _ProxyJump.ProxyOff();
        }
    }

    public void SetJumpProxy(IStateProxyOff proxy) {
        _ProxyJump = proxy;
    }
}
