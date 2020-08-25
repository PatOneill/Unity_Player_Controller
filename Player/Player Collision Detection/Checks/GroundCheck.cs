using UnityEngine;

public class GroundCheck {
    private readonly Transform _PlayerTransform;
    private Collider[] _ColliderHits;
    private readonly LayerMask _GroundLayer;
    private readonly IDynamicProxy _ProxyFall;
    private bool _IsGrounded;

    public GroundCheck(Transform playerTransform, IDynamicProxy fallProxy) {
        _PlayerTransform = playerTransform;
        _ColliderHits = new Collider[] { };
        _GroundLayer = LayerMask.GetMask("Ground");
        _ProxyFall = fallProxy;
        _IsGrounded = true;
    }

    public void CheckForGround() {
        //Draws a box at the feet of the player and checks to see if any collider in the Ground layer are overlapping or colliding with drawn box
        //If a overlap or collision is found, set ground true else set false
        
        Vector3 tempPos = _PlayerTransform.position;
        _ColliderHits = Physics.OverlapBox(new Vector3(tempPos.x, tempPos.y - 1.0f, tempPos.z), new Vector3(0.15f, 0.1f, 0.15f), _PlayerTransform.rotation, _GroundLayer);
        if(_ColliderHits.Length > 0) {
            if(_IsGrounded) { return;  } //Don't continuously call state controller with repetitive messages that the player is grounded
            _ProxyFall.DeactivateProxy(); //Player is grounded
            _IsGrounded = true;
        } else {
            if(!_IsGrounded) { return; } //Don't continuously call state controller with repetitive messages that the player is falling
            _ProxyFall.ActiveProxy(); //Player is not grounded
            _IsGrounded = false;
        }
    }
}
