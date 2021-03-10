public class PlayerHUDUI : AUIElement {
    private UnityHUDFunctionality _HUDFunctionalityUnity;

    public UnityHUDFunctionality HUDControllerUnity { get => _HUDFunctionalityUnity; set => _HUDFunctionalityUnity = value; }

    public PlayerHUDUI(PlayerUIController uiController) {
        /**
         * @desc All UI elements are set to null on the player's Awake method call. This is done because we can't be sure that unity will always execute UnityUIController's Awake method before PlayerMain's Awake method
         * NOTE: UI elements will be set in player's start methods and not the Awake method
        */
        _HUDFunctionalityUnity = null;
        _UIControllerPlayer = uiController;
    }

    public void StaminaWasIncreased(float newStaminaPercentage) {
        /**
         * @desc Updates the visual indicator along with playing any UI related effects
         * @parm float $newStaminaPercentage - the player's new stamina value represented as a percentage
        */
        _HUDFunctionalityUnity.UpdateStaminaBarSlider(newStaminaPercentage);
    }

    public void StaminaWasDecreased(float newStaminaPercentage) {
        /**
         * @desc Updates the visual indicator along with playing any UI related effects
         * @parm float $newStaminaPercentage - the player's new stamina value represented as a percentage
        */
        _HUDFunctionalityUnity.UpdateStaminaBarSlider(newStaminaPercentage);
    }

    public override void DisplayGameMenu() {
        _UIControllerPlayer.ChangeUI(_UIControllerPlayer.GetGameMenuUIPlayer());
    }

    public override void UIDisplayOn() {
        /**
          * @desc Enable the player's HUD display and script functionality
        */
        _HUDFunctionalityUnity.UIDisplayOn();
    }

    public override void UIDisplayOff() {
        /**
          * @desc Disable the player's HUD display and script functionality
        */
        _HUDFunctionalityUnity.UIDisplayOff();
    }
}
