using UnityEngine;

public class PhysicsWall {
    private IStateProxyOnOff _ProxyWalk;
    private Collider[] _ColliderHits;
    private RaycastHit _Raycast;
    private readonly LayerMask _HorizontalBlockingLayers;
    private readonly LayerMask _WallCollisionLayers;
    private readonly PlayerPhysics _PhysicsPlayer;
    private readonly Transform _PlayerTransform;
    private readonly float _RaycastLength;
    private readonly float _ImpactMagnitude;
    private readonly float _VisualBodyOffset;
    private readonly float _PlayerMass;
    private readonly Vector3 _PlayerScale;

    public PhysicsWall(PlayerPhysics playerPhysics, Transform playerTransform) {
        _PhysicsPlayer = playerPhysics;
        _PlayerTransform = playerTransform;
        _PlayerScale = _PlayerTransform.localScale;
        _PlayerMass = _PhysicsPlayer.PlayerMass;
        _ColliderHits = new Collider[] { };
        _Raycast = new RaycastHit();
        _VisualBodyOffset = 0.5f;
        _RaycastLength = 1.0f;
        _ImpactMagnitude = 0.1f;
        _HorizontalBlockingLayers = LayerMask.GetMask("Wall", "Ground");
        _WallCollisionLayers = LayerMask.GetMask("Wall");
    }

    public void BoundingBoxCheck(Vector3 tentativeNewLocation) {
        Vector3 pLocation = _PlayerTransform.position;

        //Calculate the midpoint to cast the bounding box from
        Vector3 boundingCastCenter = new Vector3(pLocation.x + tentativeNewLocation.x, pLocation.y + tentativeNewLocation.y, pLocation.z + tentativeNewLocation.z) / 2f;

        //Calculate the size needed for the bounding box
        Vector3 boundingSize = new Vector3(Mathf.Abs(pLocation.x - tentativeNewLocation.x) + _PlayerScale.x / 4f, _PhysicsPlayer.HeadOffset / 3f, Mathf.Abs(pLocation.z - tentativeNewLocation.z) + _PlayerScale.x / 4f);

        //Cast the bounding box and check for collisions
        _ColliderHits = Physics.OverlapBox(boundingCastCenter, boundingSize, _PlayerTransform.rotation, _HorizontalBlockingLayers);
        if (_ColliderHits.Length > 0) {
            TunnelingCheck(tentativeNewLocation);
        }
    }

    private void TunnelingCheck(Vector3 tentativeNewLocation) {

    }

    public void SetWalkProxy(IStateProxyOnOff proxy) {
        _ProxyWalk = proxy;
    }
}
