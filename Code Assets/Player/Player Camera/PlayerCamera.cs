using System.Collections;
using UnityEngine;

public class PlayerCamera : ICameraInput {
    private readonly Camera _PlayerMainCamera;
    private readonly Transform _PlayerTransform;
    private readonly Transform _CameraTransform;
    private readonly PlayerMain _MainPlayer;

    private readonly LookProxy _ProxyLook;
    private Vector3 _LookDirection;
    private float _CameraSensitivity;
    private float _YCameraRotation;
    private bool _IsActive;
    private IEnumerator _CameraTransitionStanding;
    private IEnumerator _CameraTransitionCrouching;

    private readonly Vector3 _CameraStandingPosition;
    private readonly Vector3 _CameraCrouchingPosition;
    private readonly float _SmoothTransition;
    private Vector3 _CameraVelocity;
    private bool _IsStanding;

    public bool IsActive { set => _IsActive = value; }

    public LookProxy ProxyLook() { return _ProxyLook; }

    public PlayerCamera(Transform playerTransform, Camera playerCamera, PlayerMain playerMain) {
        _PlayerMainCamera = playerCamera;
        _CameraTransform = playerCamera.transform;
        _PlayerTransform = playerTransform;
        _MainPlayer = playerMain;

        _ProxyLook = new LookProxy(this);
        _LookDirection = Vector3.zero;
        _CameraSensitivity = 100.0f;
        _YCameraRotation = 0.0f;
        _IsActive = false;
        _IsStanding = true;
        _CameraStandingPosition = new Vector3(0.0f, 1.0f, 0.0f);
        _CameraCrouchingPosition = new Vector3(0.0f, 0.4f, 0.0f);
        _CameraTransitionStanding = UpdateYPoitionToStanding();
        _CameraTransitionCrouching = UpdateYPoitionToCrouching();

        _CameraVelocity = new Vector3(0f,0.5f,0.0f);
        _SmoothTransition = 0.3f;
    }

    public void UpdateCamera() {
        if (!_IsActive) { return; } //Only rotate camera and player if input for the camera is active 
        float yInput = _LookDirection.y * _CameraSensitivity * Time.deltaTime;

        _YCameraRotation -= yInput;
        _YCameraRotation = Mathf.Clamp(_YCameraRotation, -60.0f, 70.0f);

        _PlayerMainCamera.transform.localRotation = Quaternion.Euler(Vector3.right * _YCameraRotation); //Rotate camera up and down 
        float xInput = _LookDirection.x * _CameraSensitivity * Time.deltaTime;
        _PlayerTransform.Rotate(Vector3.up * xInput); //Rotate player object left and right
    }

    public void TransitionCameraStanding() {
        if (!_IsStanding) { //Don't start more than one coroutine at a time
            _IsStanding = true;

            _MainPlayer.StopCoroutine(_CameraTransitionCrouching); //If the player's camera is moving to the crouching position kill it
            _CameraTransitionCrouching = UpdateYPoitionToCrouching(); //Assign a new instance of the coroutine
            
            _MainPlayer.StartCoroutine(_CameraTransitionStanding); //Start moving the player's camera in the direction of the standing position
        }
    }

    public void TransitionCameraCrouching() {
        if (_IsStanding) { //Don't start more than one coroutine at a time
            _IsStanding = false;

            _MainPlayer.StopCoroutine(_CameraTransitionStanding); //If the player's camera is moving to the standing position kill it
            _CameraTransitionStanding = UpdateYPoitionToStanding(); //Assign a new instance of the coroutine

            _MainPlayer.StartCoroutine(_CameraTransitionCrouching); //Start moving the player's camera in the direction of the crouching position
        }
    }

    public IEnumerator UpdateYPoitionToStanding() {
        while (_CameraTransform.localPosition.y < (_CameraStandingPosition.y - 0.05)) {
            Vector3 tempLocation = Vector3.SmoothDamp(_CameraTransform.localPosition, _CameraStandingPosition, ref _CameraVelocity, _SmoothTransition);

            tempLocation.x = _CameraTransform.localPosition.x;
            tempLocation.z = _CameraTransform.localPosition.z;
            _CameraTransform.localPosition = tempLocation; //The only methods that edit the camera's local y axis are the coroutines
            
            yield return null; //Wait for the next frame
        }        
    }

    public IEnumerator UpdateYPoitionToCrouching() {
        while (_CameraTransform.localPosition.y > (_CameraCrouchingPosition.y + 0.05)) {
            Vector3 tempLocation = Vector3.SmoothDamp(_CameraTransform.localPosition, _CameraCrouchingPosition, ref _CameraVelocity, _SmoothTransition);

            tempLocation.x = _CameraTransform.localPosition.x;
            tempLocation.z = _CameraTransform.localPosition.z;
            _CameraTransform.localPosition = tempLocation; //The only methods that edit the camera's local y axis are the coroutines

            yield return null; //Wait for the next frame
        }
    }

    public void Update(Vector2 direction) {
        _LookDirection = direction;
    }
}
