using UnityEngine;

public class PlayerCamera : IInputObserver {
    private Camera _PlayerCamera;
    private Transform _PlayerTransform;

    private bool _IsActive;
    private Vector2 _Direction;
    private float _Sensitivity;
    private float _YCameraRotation;

    public bool IsActive { set => _IsActive = value; }

    public PlayerCamera(Camera playerCamera, Transform playerTransform) {
        _PlayerCamera = playerCamera;
        _PlayerTransform = playerTransform;
        _YCameraRotation = 0.0f;
        _Sensitivity = 100.0f;
        _IsActive = false;
    }

    public void UpdateCamera() {
        if (!_IsActive) { return; } //Only rotate camera and player if input for the camera is active 
        float yInput = _Direction.y * _Sensitivity * Time.deltaTime;

        _YCameraRotation -= yInput;
        _YCameraRotation = Mathf.Clamp(_YCameraRotation, -60.0f, 70.0f);

        _PlayerCamera.transform.localRotation = Quaternion.Euler(Vector3.right * _YCameraRotation); //Rotate camera up and down 
    }

    public void RotateRigidbodyWithCamera() {
        if (!_IsActive) { return; } //Only rotate camera and player if input for the camera is active 
        float xInput = _Direction.x * _Sensitivity * Time.deltaTime;
        _PlayerTransform.Rotate(Vector3.up * xInput); //Rotate player object left and right
    }

    public void Update(Vector2 direction) {
        _Direction = direction;
    }

    //TODO:
        //Find a way to move the camera more smoothly than current method
}
