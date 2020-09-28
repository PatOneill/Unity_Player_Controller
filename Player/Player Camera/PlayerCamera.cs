using UnityEngine;

public class PlayerCamera : ICameraInput {
    private readonly Camera _PlayerMainCamera;
    private readonly Transform _PlayerTransform;
    private readonly LookProxy _ProxyLook;
    private Vector3 _LookDirection;

    private float _CameraSensitivity;
    private float _YCameraRotation;
    private bool _IsActive;

    public bool IsActive { set => _IsActive = value; }

    public LookProxy ProxyLook() { return _ProxyLook; }

    public PlayerCamera(Transform playerTransform, Camera playerCamera) {
        _PlayerMainCamera = playerCamera;
        _PlayerTransform = playerTransform;
        _ProxyLook = new LookProxy(this);
        _LookDirection = Vector3.zero;
        _CameraSensitivity = 100.0f;
        _YCameraRotation = 0.0f;
        _IsActive = false;
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

    public void RotateRigidbodyWithCamera() {
        if (!_IsActive) { return; } //Only rotate camera and player if input for the camera is active 
        float xInput = _LookDirection.x * _CameraSensitivity * Time.deltaTime;
        _PlayerTransform.Rotate(Vector3.up * xInput); //Rotate player object left and right
    }

    public void Update(Vector2 direction) {
        _LookDirection = direction;
    }
}
