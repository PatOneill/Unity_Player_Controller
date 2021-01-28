using UnityEngine;

public class PlayerPhysics : IAnalogInputObserver {
    #region Physics Variables
    private readonly Transform _PlayerTransform;
    private readonly PhysicsGrounded _GroundedPhysics;
    private readonly PhysicsCeiling _CeilingPhysics;
    private readonly PhysicsWall _WallPhysics;
    private readonly PhysicsItemPickup _DetectItemsPhysics;

    private readonly float _InitialJumpVelocity;

    private readonly float _PlayerMass;

    private float _HorizontalVelocity;
    private float _VerticalVelocity;

    private Vector3 _HorizontalDirection;
    private Vector3 _VerticalDirection;
    private Vector2 _AnalogInput;

    private readonly float _GroundOffset;
    private float _FeetOffset;
    private float _HeadOffset;
    #endregion

    public PlayerPhysics(Rigidbody playerRigidbody) {
        _PlayerTransform = playerRigidbody.transform;
        _HorizontalVelocity = 0.0f;
        _VerticalVelocity = 0.0f;

        _HorizontalDirection = Vector3.zero;
        _VerticalDirection = Vector3.down;
        _AnalogInput = Vector2.zero;

        _InitialJumpVelocity = 5.0f;

        _PlayerMass = 1.0f;

        _FeetOffset = -1f;
        _HeadOffset = 1.0f;
        _GroundOffset = 0.05f;

        _GroundedPhysics = new PhysicsGrounded(this, _PlayerTransform);
        _CeilingPhysics = new PhysicsCeiling(this, _PlayerTransform);
        _WallPhysics = new PhysicsWall(this, _PlayerTransform);
        _DetectItemsPhysics = new PhysicsItemPickup();
    }

    #region Gets and Sets for the Physics Variables
    public float HorizontalVelocity { get => _HorizontalVelocity; set => _HorizontalVelocity = value; }
    public float VerticalVelocity { get => _VerticalVelocity; set => _VerticalVelocity = value; }
    public float FeetOffset { get => _FeetOffset; }
    public float HeadOffset { get => _HeadOffset; }
    public float PlayerMass { get => _PlayerMass; }
    public float GroundOffset { get => _GroundOffset; }
    public Vector3 HorizontalDirection { get => _HorizontalDirection; set => _HorizontalDirection = value; }
    public Vector3 VerticalDirection { get => _VerticalDirection; }

    public PhysicsGrounded GetGroundCheck() { return _GroundedPhysics; }
    public PhysicsCeiling GetCeilingCheck() { return _CeilingPhysics; }
    public PhysicsWall GetWallCheck() { return _WallPhysics; }
    public PhysicsItemPickup GetItemPickupCheck() { return _DetectItemsPhysics; }
    #endregion

    #region Crouching/Standing Physics Parameters Update Functions
    public void SetBodyStanding() {
        _HeadOffset = 1.0f;
    }

    public void SetBodyCrouching() {
        _HeadOffset = 0.75f;
    }
    #endregion

    #region Horizontal Direction Calculations
    public void CalculateHorizontalDirection() {
        _HorizontalDirection = (_PlayerTransform.right * _AnalogInput.x) + (_PlayerTransform.forward * _AnalogInput.y); //Determine the direction the player wants to move in
    }

    public void NormalizeHorizontalDirection() {
        _HorizontalDirection = (_PlayerTransform.right * _AnalogInput.x) + (_PlayerTransform.forward * _AnalogInput.y).normalized; //Determine the direction the player wants to move in
    }
    #endregion

    #region Horizontal Collision Checks
    public void HorizontalXZMovement(Vector3 tentativeNewLocation) {
        _WallPhysics.BoundingBoxCheck(tentativeNewLocation);
    }
    #endregion

    public void SetInitialJumpVelocity() { //Change the player's vertical velocity to a positive value on the inital frame of the jump
        _VerticalVelocity = _InitialJumpVelocity;
    }

    public void Update(Vector2 direction) { //Check for changes in the player's analog stick
        _AnalogInput = direction;
    }
}
