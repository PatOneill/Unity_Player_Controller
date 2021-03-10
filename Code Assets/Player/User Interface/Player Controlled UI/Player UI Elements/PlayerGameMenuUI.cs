public class PlayerGameMenuUI : AUIElement {
    private UnityGameMenuFunctionality _GameMenuFunctionalityUnity;

    public UnityGameMenuFunctionality GameMenuControllerUnity { get => _GameMenuFunctionalityUnity; set => _GameMenuFunctionalityUnity = value; }

    public PlayerGameMenuUI(PlayerUIController uiController) {
        /**
         * @desc All UI elements are set to null on the player's Awake method call. This is done because we can't be sure that unity will always execute UnityUIController's Awake method before PlayerMain's Awake method
         * NOTE: UI elements will be set in player's start methods and not the Awake method
        */
        _GameMenuFunctionalityUnity = null;
        _UIControllerPlayer = uiController;
    }

    public override void DisplayGameMenu() {
        _UIControllerPlayer.ChangeUI(_UIControllerPlayer.GetHUDUIPlayer());
    }

    public override void DisplayHUD() {
        _UIControllerPlayer.ChangeUI(_UIControllerPlayer.GetHUDUIPlayer());
    }


    public override void UIDisplayOn() {
        /**
          * @desc Enable the player's game menu display and script functionality
        */
        _GameMenuFunctionalityUnity.UIDisplayOn();
    }

    public override void UIDisplayOff() {
        /**
          * @desc Disable the player's game menu display and script functionality
        */
        _GameMenuFunctionalityUnity.UIDisplayOff();
    }
}
