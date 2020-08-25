using UnityEngine;

public class GravityMovement {
    private float _GravityAccleration;
    private Rigidbody _PlayerRigidbody;

    public GravityMovement(Rigidbody playerRigidbody) {
        _GravityAccleration = -4.5f;
        _PlayerRigidbody = playerRigidbody;
    }

    public void ApplyGravity() { //Work in progrss
        Vector3 currentVelocity = _PlayerRigidbody.velocity;
        Vector3 currentPosition = _PlayerRigidbody.position;

        //Calculate displacement 
        currentPosition.y += (currentVelocity.y * Time.deltaTime) + (0.5f * _GravityAccleration * Mathf.Pow(Time.deltaTime, 2));

        //Calculate new velocity 
        currentVelocity.y += (_GravityAccleration * Time.deltaTime);

        _PlayerRigidbody.MovePosition(currentPosition);
    }

    //TODO:
        //Fix the functionality/math of ApplyGravity
        //Handle horizontal motions while falling
}
