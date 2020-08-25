using UnityEngine;

public class MoveCheck {
    private Collider[] _ColliderHits;
    private readonly LayerMask _ObjectLayers;

    public MoveCheck() {
        _ColliderHits = new Collider[] { };
        _ObjectLayers = LayerMask.GetMask("Ground", "Wall");
    }

    public bool CheckForCollision(Vector3 newPosition) { //Check to see if a gameobject with a collider exist in the location another gameobject wants to move to
        _ColliderHits = Physics.OverlapBox(new Vector3(newPosition.x, newPosition.y, newPosition.z), new Vector3(0.2f, 0.2f, 0.2f), Quaternion.Euler(0.0f, 0.0f, 0.0f), _ObjectLayers);
        if (_ColliderHits.Length > 0) {
            return true;
        } else {
            return false;
        }
    }

    //TODO:
        //Communicate with other class when dealing with walls at an angle
        //Handle CheckForCollision slightly clipping object when the gameobject that is moving is parallel
}
