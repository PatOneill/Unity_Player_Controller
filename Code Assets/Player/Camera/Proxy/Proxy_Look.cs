using UnityEngine;

public class Proxy_Look : IDynamicProxies, IInputProxies {
    private PlayerCameraController _CameraControllerPlayer;
    private bool _InputActive;

    public Proxy_Look(PlayerCameraController cameraController) {
        _CameraControllerPlayer = cameraController;
        _InputActive = false;
    }

    public void InputActive() {
        /**
         * @desc The input for this proxy is active 
        */
        _InputActive = true;
        CheckActivation();
    }

    public void InputInactive() {
        /**
         * @desc The input for this proxy is no longer active
        */
        _InputActive = false;
        CheckActivation();
    }

    public void CheckActivation() {
        /**
         * @desc Ensure this proxy is active/inactive as its internal parms changes and external parameters change as well
        */
        if (_InputActive) {
            SendRequest();
        } else {
            RetractRequest();
        }
    }

    public void SendRequest() {
        /**
          * @desc Tell the camera controller that it should begin to update the camera's rotation along with the player's riigidbody rotation
        */
        _CameraControllerPlayer.CanCameraMove(true);
    }

    public void RetractRequest() {
        /**
          * @desc Tell the camera controller that it no longer need to update the camera's rotation and the player's riigidbody rotation
        */
        _CameraControllerPlayer.CanCameraMove(false);
    }
}
