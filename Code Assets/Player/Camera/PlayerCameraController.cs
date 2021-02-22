using UnityEngine;

public class PlayerCameraController : IInputObserver {
    private Rigidbody _PlayerRigidbody;
    private Proxy_Look _LookProxy;
    private Camera _PlayerCamera;
    private bool _CanCameraMove;
    private Vector2 _LookDirection;
    private float _CameraLookSensitivity;
    private float _CameraXRotation;
    private float _RigidbodyYRotation;

    public PlayerCameraController(Camera playerCamera, Rigidbody playerRigidbody) {
        _PlayerRigidbody = playerRigidbody;
        _LookProxy = new Proxy_Look(this);
        _PlayerCamera = playerCamera;
        _CanCameraMove = false;
        _LookDirection = Vector2.zero;
        _CameraLookSensitivity = 100.0f;
        _CameraXRotation = 0.0f;
        _RigidbodyYRotation = 0.0f;
    }

    public void InputDrivenPlayerCameraMotion() {
        /**
         * @desc As the player moves the analog stick tied to the look action, update both the player's camera's rotation and the player's rigidbody's rotation 
        */
        if (_CanCameraMove) { //Only update the camera's and rigidbody's rotations if the input is active
            //Handle the X axis rotation of the camera
            float newCameraXRotation = _LookDirection.y * _CameraLookSensitivity * Time.deltaTime;
            _CameraXRotation -= newCameraXRotation; //Keep track of the per frame changes to the camera's rotation on the X axis
            _CameraXRotation = Mathf.Clamp(_CameraXRotation, -60.0f, 70.0f); //Ensure that the player's camera's rotation on the X axis doesn't surpass given values to provide proper behavior when rotating
            _PlayerCamera.transform.localRotation = Quaternion.Euler(Vector3.right * _CameraXRotation); //Rotate camera up and down on the X axis using the camera's parent gameobject (Player gameobject) as its reference point

            //Handle the Y axis rotation of the player's rigidbody
            float newRigidbodyYRotation = _LookDirection.x * _CameraLookSensitivity * Time.deltaTime;
            _RigidbodyYRotation += newRigidbodyYRotation; //Keep tracj of the per frame changes to the rigidbody's rotation on the Y axis
            _PlayerRigidbody.MoveRotation(Quaternion.Euler(Vector3.up * _RigidbodyYRotation)); //Rotate camera left and right on the Y axis using worlds space for rotation
        }
    }

    public void CanCameraMove(bool newValue) {
        /**
         * @desc Informs the camera controller that the camera need to start moving or stop depending on the value given 
        */
        _CanCameraMove = newValue;
    }

    public void Update(Vector2 direction) {
        /**
         * @desc Get the direction the player wants to look towards from the player's input controller (Note: This method is only called while the inputs assigned to the look action have their values altered)
         * @parm Vector2 $direction - Holds the direction the player wishes to look towards
        */
        _LookDirection = direction;
    }

    public Proxy_Look GetLookProxy() {
        return _LookProxy;
    }
}
