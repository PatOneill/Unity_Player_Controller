public class PlayerHUDController {
    private UnityHUDController _HUDControllerUnity;

    public UnityHUDController HUDControllerUnity { get => _HUDControllerUnity; set => _HUDControllerUnity = value; }

    public PlayerHUDController() {
        /**
         * @desc All UI elements are set to null on the player's Awake method call. This is done because we can't be sure that unity will always execute UnityUIController's Awake method before PlayerMain's Awake method
         * NOTE: UI elements will be set in player's start methods and not the Awake method
        */
        _HUDControllerUnity = null;
    }

    public void StaminaWasIncreased(float newStaminaPercentage) {
        /**
         * @desc Updates the visual indicator along with playing any UI related effects
         * @parm float $newStaminaPercentage - the player's new stamina value represented as a percentage
        */
        _HUDControllerUnity.UpdateStaminaBarSlider(newStaminaPercentage);
    }

    public void StaminaWasDecreased(float newStaminaPercentage) {
        /**
         * @desc Updates the visual indicator along with playing any UI related effects
         * @parm float $newStaminaPercentage - the player's new stamina value represented as a percentage
        */
        _HUDControllerUnity.UpdateStaminaBarSlider(newStaminaPercentage);
    }
}
