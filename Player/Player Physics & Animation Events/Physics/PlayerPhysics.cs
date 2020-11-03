using UnityEngine;

public class PlayerPhysics : IAnalogInputObserver {
    private readonly Transform _PlayerTransform;
    private Vector2 _AnalogInput;

    private readonly Vector3 _StandingMoveCheckSize;
    private readonly Vector3 _CrouchingMoveCheckSize;
    private readonly Vector3 _GroundCheckSize;
    private readonly Vector3 _CeilingCheckSize;
    private Vector3 _CurrentMoveCheckSize;

    private Vector2 _CurrentVelocity;

    private LayerMask _HorizontalCollisionLayers;
    private LayerMask _GroundCollisionLayers;
    private LayerMask _WallCollisionLayers;
    private LayerMask _CeilingCollisionLayers;

    private readonly float _RaycastLenght;
    private readonly float _RaycastCornerLenght;
    private readonly float _MaxSlopeAngle;
    private float _MiddleOffset;
    private float _HeadOffset;
    private Collider[] _ColliderHits;
    private RaycastHit _RaycastDirectCollision;
    private Vector3 _HorizontalDirection;

    private Vector3 _NewGroundLocation;
    private Vector3 _NewGroundDirection;

    private Rigidbody _PlayerRigidbody;
    private readonly float _GroundOffset;
    private RaycastHit _RaycastCollision;
    private readonly float _Time;
    private readonly float _InitialJumpVelocity;

    private readonly PhysicsGrounded _GroundedPhysics;
    private readonly PhysicsCeiling _CeilingPhysics;

    public PlayerPhysics(Rigidbody playerRigidbody) {
        _PlayerRigidbody = playerRigidbody;
        _PlayerTransform = playerRigidbody.transform;
        _AnalogInput = Vector2.zero;

        _StandingMoveCheckSize = new Vector3(0.25f, 0.4f, 0.25f);
        _CrouchingMoveCheckSize = new Vector3(0.25f, 0.2f, 0.25f);
        _GroundCheckSize = new Vector3(0.1f, 0.25f, 0.1f);
        _CeilingCheckSize = new Vector3(0.1f, 0.1f, 0.1f);
        _CurrentMoveCheckSize = _StandingMoveCheckSize;

        _CurrentVelocity = Vector3.zero;

        _HorizontalCollisionLayers = LayerMask.GetMask("Wall", "AI");
        _GroundCollisionLayers = LayerMask.GetMask("Ground");
        _WallCollisionLayers = LayerMask.GetMask("Wall");
        _CeilingCollisionLayers = LayerMask.GetMask("Ceiling");

        _RaycastLenght = 1.0f;
        _RaycastCornerLenght = 0.1f;
        _MaxSlopeAngle = 45.0f;
        _MiddleOffset = 0.5f;
        _HeadOffset = 1.5f;
        _ColliderHits = new Collider[] { };
        _RaycastDirectCollision = new RaycastHit();
        _HorizontalDirection = Vector3.zero;

        _NewGroundLocation = Vector3.zero;
        _NewGroundDirection = Vector3.zero;

        _GroundOffset = 0.05f;
        _RaycastCollision = new RaycastHit();
        _Time = 0.5f;

        _InitialJumpVelocity = 5.0f;

        _GroundedPhysics = new PhysicsGrounded(this, _PlayerTransform, _GroundCollisionLayers, _GroundCheckSize);
        _CeilingPhysics = new PhysicsCeiling(this, _PlayerTransform, _CeilingCollisionLayers, _CeilingCheckSize, _HeadOffset);
    }

    #region Physic Function Helpers
    public Vector3 HorizontalDirection { get => _HorizontalDirection; }

    public Vector2 CurrentVelocity { get => _CurrentVelocity; set => _CurrentVelocity = value; }

    public Vector2 AnalogInput { get => _AnalogInput; }

    public void SetBodyStanding() {
        _CurrentMoveCheckSize = _StandingMoveCheckSize;
        _MiddleOffset = 0.5f;
    }

    public void SetBodyCrouching() {
        _CurrentMoveCheckSize = _CrouchingMoveCheckSize;
        _MiddleOffset = 0.25f;
    }

    public PhysicsGrounded GetGroundCheck() {
        return _GroundedPhysics;
    }

    public PhysicsCeiling GetCeilingCheck() {
        return _CeilingPhysics;
    }

    public Vector3 CalculateHorizontalDirection() {
        _HorizontalDirection = (_PlayerTransform.right * _AnalogInput.x) + (_PlayerTransform.forward * _AnalogInput.y); //Determine the direction the player wants to move in
        return _HorizontalDirection;
    }

    public Vector3 CalculateHorizontalDirectionMidAir() { //Used only when we don't want to change the players current move direction (eg strafing and sliding)
        return (_PlayerTransform.right * _AnalogInput.x) + (_PlayerTransform.forward * _AnalogInput.y); //Determine the direction the player wants to move in
    }
    #endregion

    #region Horizontal Move Collision Checks
    public void HorizontalMoveCheck(Vector3 moveToPosition) {
        MoveBodyCheck(moveToPosition);
        MoveOnSlopeCheck(moveToPosition);
        FixedToGround();
    }

    public void AerialHorizontalMoveCheck(Vector3 moveToPosition) {
        MoveBodyCheck(moveToPosition);
    }

    private void MoveBodyCheck(Vector3 location) {
        location.y += _MiddleOffset;
        _ColliderHits = Physics.OverlapBox(location, _CurrentMoveCheckSize, _PlayerTransform.rotation, _HorizontalCollisionLayers);
        if (_ColliderHits.Length == 0) {
            return; //The player is not colliding with some physics object at the desired location
        } else {
            location = _PlayerTransform.position;
            location.y += _MiddleOffset;
            RaycastPlayerDirectionCollision(location, _HorizontalDirection); //Check to see if the player can move along the object they are colliding with
        }
    }

    private void RaycastPlayerDirectionCollision(Vector3 firePostion, Vector3 direction) {
        if (Physics.Raycast(firePostion, direction, out _RaycastDirectCollision, _RaycastLenght, _HorizontalCollisionLayers)) {
            _HorizontalDirection = Vector3.ProjectOnPlane(_HorizontalDirection, _RaycastDirectCollision.normal);
            firePostion = (_RaycastDirectCollision.point + _PlayerTransform.position) / 2.0f;
            RaycastPlayerIndirectCollisions(firePostion, _HorizontalDirection);
        }
    }

    private void RaycastPlayerIndirectCollisions(Vector3 firePostion, Vector3 direction) {
        if (Physics.Raycast(firePostion, direction, out _RaycastDirectCollision, _RaycastCornerLenght, _HorizontalCollisionLayers)) {
            if (_WallCollisionLayers == (_WallCollisionLayers | (1 << _RaycastDirectCollision.transform.gameObject.layer))) {
                _HorizontalDirection = Vector3.zero;
            } else {
                _HorizontalDirection = Vector3.ProjectOnPlane(_HorizontalDirection, _RaycastDirectCollision.normal);
                firePostion = (_RaycastDirectCollision.point + _PlayerTransform.position) / 2.0f;
                RaycastPlayerIndirectCollisions(firePostion, _HorizontalDirection);
            }
        }
    }

    private void MoveOnSlopeCheck(Vector3 location) {
        location.y += _MiddleOffset;
        if (Physics.Raycast(location, -_PlayerTransform.up, out _RaycastDirectCollision, _RaycastLenght, _GroundCollisionLayers)) {
            _NewGroundLocation = _RaycastDirectCollision.point;
            if ((Vector3.Angle(_RaycastDirectCollision.normal, -_HorizontalDirection) - 90.0f) <= _MaxSlopeAngle) { //Is the angle of the slope valid
                if (_RaycastDirectCollision.normal != Vector3.up) { //The player is getting on a slope, move on a slope, or between slopes
                    _HorizontalDirection = Vector3.ProjectOnPlane(_HorizontalDirection, _RaycastDirectCollision.normal);
                }
            } else {
                _HorizontalDirection = Vector3.zero;
            }
        }
    }
    #endregion

    #region Vertical Move Collision Checks
    public void SetInitialJumpVelocity() {
        _CurrentVelocity.y = _InitialJumpVelocity;
    }

    private void FixedToGround() { //Force the player to stick to the ground
        Vector3 fireLocation = _PlayerTransform.position;
        fireLocation.y += _MiddleOffset;
        if (Physics.Raycast(fireLocation, -_PlayerTransform.up, out _RaycastCollision, _RaycastLenght, _GroundCollisionLayers)) {
            if (_RaycastCollision.distance >= (_MiddleOffset + _GroundOffset)) {
                fireLocation = _PlayerTransform.position;
                _NewGroundDirection = _NewGroundLocation - fireLocation;
                _HorizontalDirection.y += _NewGroundDirection.y;
            } else if (_RaycastCollision.distance <= (_MiddleOffset - _GroundOffset)) {
                fireLocation = _PlayerTransform.position;
                _NewGroundDirection = _NewGroundLocation - fireLocation;
                _HorizontalDirection.y += _NewGroundDirection.y;
            }
        }
    }

    public void AttractToGround() { //Force the player to stick to the ground
        Vector3 fireLocation = _PlayerTransform.position;
        fireLocation.y += _MiddleOffset;
        if (Physics.Raycast(fireLocation, -_PlayerTransform.up, out _RaycastCollision, _RaycastLenght, _GroundCollisionLayers)) {
            if (_RaycastCollision.distance >= (_MiddleOffset + _GroundOffset)) {
                fireLocation = _PlayerTransform.position;
                fireLocation.y = Mathf.Lerp(_PlayerTransform.position.y, _RaycastCollision.point.y, _Time);
                _PlayerRigidbody.MovePosition(fireLocation);
            } else if (_RaycastCollision.distance <= (_MiddleOffset - _GroundOffset)) {
                fireLocation = _PlayerTransform.position;
                fireLocation.y = Mathf.Lerp(_PlayerTransform.position.y, _RaycastCollision.point.y, _Time);
                _PlayerRigidbody.MovePosition(fireLocation);
            }
        }
    }

    #endregion

    public void Update(Vector2 direction) {
        _AnalogInput = direction;
    }
}
