using UnityEngine;

public class HorizontalMovement : IHorizontalMovementAir, IHorizontalMovementGround {
    private Rigidbody _GameObjectRigidbody;
    private Transform _RigidbodyTransform;
    private MoveCheck _CheckMove;

    public HorizontalMovement(Rigidbody playerRigidbody) {
        _GameObjectRigidbody = playerRigidbody;
        _RigidbodyTransform = _GameObjectRigidbody.transform;
        _CheckMove = new MoveCheck();
    }

    public void MoveHorizontallyAir(Vector2 direction, float modifier) {
        //Vector3 moveRB = ((_GameObjectRigidbody.transform.right * direction.x) + (_GameObjectRigidbody.transform.forward * direction.y));
        //moveRB = moveRB.normalized * modifier * Time.deltaTime;
        //_GameObjectRigidbody.MovePosition(moveRB);
    }

    public void MoveHorizontallyGround(Vector2 direction, float modifier) {
        Vector3 moveDirection = (_GameObjectRigidbody.transform.right * direction.x) + (_GameObjectRigidbody.transform.forward * direction.y); //Determine the direction the player wants to move in
        moveDirection = moveDirection * modifier * Time.deltaTime; //Calculate the displacement of the gameobject in the horizontal directions based on the speed modifier and the fix frame rate
        moveDirection += _RigidbodyTransform.position; //Add the displacement value to the player's current location
        if (_CheckMove.CheckForCollision(moveDirection)) { return; } //Don't move the this gameobject into an existing gameobject
        _GameObjectRigidbody.MovePosition(moveDirection);
    }

    //TODO:
        //Handle speed on slope angles at both a mins and a maxs values
        //Handle issues when standing on normal ground and sloped angle

}
