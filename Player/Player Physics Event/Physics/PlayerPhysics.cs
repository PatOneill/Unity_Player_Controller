using UnityEngine;

public class PlayerPhysics : IAnalogInputObserver {
    private readonly Transform _PlayerTransform;
    private Vector3 _AnalogInput;

    private readonly Vector3 _StandingMoveCheckSize;
    private readonly Vector3 _CrouchingMoveCheckSize;
    private readonly Vector3 _GroundCheckSize;
    private readonly Vector3 _CeilingCheckSize;
    private Vector3 _CurrentMoveCheckSize;

    private Vector3 _CurrentVelocity;

    private LayerMask _HorizontalCollisionLayers;
    private LayerMask _GroundCollisionLayers;
    private LayerMask _WallCollisionLayers;
    private LayerMask _CeilingCollisionLayers;

    private readonly float _RaycastLenght;
    private readonly float _MiddleOffset;
    private Collider[] _ColliderHits;
    private RaycastHit _RaycastHitSlope;
    private RaycastHit _RaycastHitWall;
    private Vector3 _HorizontalDirection;

    private readonly PhysicsGrounded _GroundedPhysics;

    public Vector3 CurrentVelocity { get => _CurrentVelocity; set => _CurrentVelocity = value; }
    public Vector3 HorizontalDirection { get => _HorizontalDirection.normalized; set => _HorizontalDirection = value; }

    public PlayerPhysics(Rigidbody playerRigidbody) {
        _PlayerTransform = playerRigidbody.transform;
        _AnalogInput = Vector3.zero;

        _StandingMoveCheckSize = new Vector3(0.25f, 0.4f, 0.25f);
        _CrouchingMoveCheckSize = new Vector3(0.25f, 0.25f, 0.25f);
        _GroundCheckSize = new Vector3(0.25f, 0.25f, 0.25f);
        _CeilingCheckSize = new Vector3(0.25f, 0.15f, 0.25f);
        _CurrentMoveCheckSize = _StandingMoveCheckSize;

        _CurrentVelocity = Vector3.zero;

        _HorizontalCollisionLayers = LayerMask.GetMask("Ground", "Wall");
        _GroundCollisionLayers = LayerMask.GetMask("Ground");
        _WallCollisionLayers = LayerMask.GetMask("Wall");
        _CeilingCollisionLayers = LayerMask.GetMask("Ceiling");

        _RaycastLenght = 1.0f;
        _MiddleOffset = 0.5f;
        _ColliderHits = new Collider[] { };
        _RaycastHitSlope = new RaycastHit();
        _RaycastHitWall = new RaycastHit();
        _HorizontalDirection = Vector3.zero;

        _GroundedPhysics = new PhysicsGrounded(this, _PlayerTransform, _GroundCollisionLayers, _GroundCheckSize);
    }

    public void SetBodyStanding() {
        _CurrentMoveCheckSize = _StandingMoveCheckSize;
    }

    public void SetBodyCrouching() {
        _CurrentMoveCheckSize = _CrouchingMoveCheckSize;
    }

    public PhysicsGrounded GetGroundCheck() {
        return _GroundedPhysics;
    }

    public Vector3 CalculateHorizontalDirection() {
        _HorizontalDirection = ((_PlayerTransform.right * _AnalogInput.x) + (_PlayerTransform.forward * _AnalogInput.y)).normalized; //Determine the direction the player wants to move in
        return _HorizontalDirection.normalized;
    }

    #region Horizontal Move Collision Checks
    public bool Grounded_HorizontalMoveCheck(Vector3 moveToPosition) { //Handles all horizontal checks for movement
        BarrierCollisionCheck(); //Check to see if the player can move along a object they are colliding with
        if (HorizontalCollisionChecks(moveToPosition)) { //Check to see if the player is moving into any type of object in the layermask that has a collider
            if (SlopeCollisionCheck(moveToPosition)) { //Check to see if the player is moving on a collider at an angle
                _HorizontalDirection = Vector3.ProjectOnPlane(_HorizontalDirection, _RaycastHitSlope.normal);
                return true; //Getting on a slope at the bottom/moving upwards on a slope
            } else {
                if (SlopeCollisionCheck(_PlayerTransform.position)) { //Check to see if the player is standing on a collider at an angle
                    _HorizontalDirection = Vector3.ProjectOnPlane(_HorizontalDirection, _RaycastHitSlope.normal);
                    return true; //Getting off a slope at its peak height
                } else {
                    return false; //Colliding with a gameobjec they are not allowed to move against
                }
            }
        } else { //Is not colliding with something 
            if (!GroundCollisionCheck(moveToPosition)) { //Check to see if the player is grounded at the new position
                if (SlopeCollisionCheck(moveToPosition)) { //Check to see if the player is moving on a collider at an angle
                    _HorizontalDirection = Vector3.ProjectOnPlane(_HorizontalDirection, _RaycastHitSlope.normal);
                    return true; //Getting on a slope at the top
                }else {
                    return true; //Trying to move in mid air
                }
            } else {
                if (SlopeCollisionCheck(_PlayerTransform.position)) { //Check to see if the player is moving on a collider at an angle
                    _HorizontalDirection = Vector3.ProjectOnPlane(_HorizontalDirection, _RaycastHitSlope.normal);
                    return true; //Getting off a slope at the bottom/moving downwards on a slope
                } else {
                    return true; //Moving normally
                }
            }
        }
    }
    
    private bool HorizontalCollisionChecks(Vector3 moveToPosition) {
        moveToPosition.y += _MiddleOffset;
        _ColliderHits = Physics.OverlapBox(moveToPosition, _CurrentMoveCheckSize, _PlayerTransform.rotation, _HorizontalCollisionLayers);
        if (_ColliderHits.Length > 0) { //The area this gameobject wants to move to is colliding with a physics body in the designated layer mask
            return true;
        } else {
            return false;
        }
    }

    private void BarrierCollisionCheck() {
        Vector3 fireFromMiddle = _PlayerTransform.position;
        fireFromMiddle.y += _MiddleOffset;
        if (Physics.Raycast(fireFromMiddle, _HorizontalDirection, out _RaycastHitWall, _RaycastLenght, _WallCollisionLayers)) { //Check to see if the player is walking into a wall or other horizontal blockers
            _HorizontalDirection = Vector3.ProjectOnPlane(_HorizontalDirection, _RaycastHitWall.normal);
        }
    }

    private bool SlopeCollisionCheck(Vector3 moveToPosition) {
        moveToPosition.y += _MiddleOffset;
        if (Physics.Raycast(moveToPosition, -_PlayerTransform.up, out _RaycastHitSlope, _RaycastLenght, _GroundCollisionLayers)) {
            if(_RaycastHitSlope.normal == Vector3.zero) {
                return false; //Player is standing on flate ground
            }
            return true;
        } else {
            return false;
        }
    }

    #endregion

    #region Vertical Move Collision Checks
    private bool GroundCollisionCheck(Vector3 newPosition) {
        _ColliderHits = Physics.OverlapBox(newPosition, _GroundCheckSize, _PlayerTransform.rotation, _GroundCollisionLayers);
        if(_ColliderHits.Length > 0) {
            return true;
        } else {
            return false;
        }
    }
    #endregion

    public void Update(Vector2 direction) {
        _AnalogInput = direction;
    }
}
