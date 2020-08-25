using System.Collections;
using UnityEngine;

public class PlayerMain : MonoBehaviour {
    private PlayerInput _InputPlayer;
    private PlayerState _StatePlayer;
    private PlayerEvent _EventPlayer;
    private PlayerCamera _CameraPlayer;
    private PlayerCollision _CollisionPlayer;

    private Transform _PlayerTransform;
    private Rigidbody _PlayerRigidbody;
    private Camera _PlayerCamera;

    private void Awake() {
        _PlayerRigidbody = this.gameObject.GetComponent<Rigidbody>();
        _PlayerCamera = this.gameObject.GetComponentInChildren<Camera>();
        _PlayerTransform = this.gameObject.transform;

        _CameraPlayer = new PlayerCamera(_PlayerCamera, _PlayerTransform); ;
        _EventPlayer = new PlayerEvent(_PlayerRigidbody);
        _StatePlayer = new PlayerState(_CameraPlayer);
        _CollisionPlayer = new PlayerCollision(_PlayerTransform, _StatePlayer);
        _InputPlayer = new PlayerInput(_StatePlayer, _EventPlayer, _CameraPlayer);
        _InputPlayer.ActivateInputDevice();
    }

    private void Start() {
        return;
    }

    private void FixedUpdate() {
        _CollisionPlayer.GroundDetection(); //Check to see if the player is colliding with or inside another collider on the layer called Ground
        _EventPlayer.CurrentEvent.ExecuteEvent(); //Executes the player's current physics and animation events
    }

    private void Update() {
       
        _StatePlayer.CheckActiveProxy(); //Updates player's current state
        _StatePlayer.CurrentPlayerState.ExecuteStateEvent(_EventPlayer); //Updates player's current physics event and animation event
    }

    private void LateUpdate() {
        _CameraPlayer.RotateRigidbodyWithCamera(); //Updates Rigidbody's X axis rotation to match camera rotation
        _CameraPlayer.UpdateCamera(); //Updates camera's Y axis rotation
    }
}
