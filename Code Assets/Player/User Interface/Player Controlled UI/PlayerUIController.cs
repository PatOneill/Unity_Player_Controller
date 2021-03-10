public class PlayerUIController {
    private UnityUIFunctionalityController _UIControllerUnity;
    private AUIElement _CurrentActiveDisplay;
    private PlayerHUDUI _HUDUIPlayer;
    private PlayerGameMenuUI _GameMenuUIPlayer;

    public AUIElement CurrentActiveDisplay { get => _CurrentActiveDisplay; }

    public PlayerUIController(UnityUIFunctionalityController unityUI) {
        _UIControllerUnity = unityUI;
        _HUDUIPlayer = new PlayerHUDUI(this);
        _GameMenuUIPlayer = new PlayerGameMenuUI(this);
        _CurrentActiveDisplay = _HUDUIPlayer;
    }

    public void SetUIElements() {
        /**
         * @desc Sets all player related UI elements in the start method of the player class. 
         * NOTE: This is done because we can't be sure that unity will always execute UnityUIController's Awake method before PlayerMain's Awake method
        */
        _HUDUIPlayer.HUDControllerUnity = _UIControllerUnity.GetUnityHUDController();
        _GameMenuUIPlayer.GameMenuControllerUnity = _UIControllerUnity.GetUnityGameMenuController();
        _CurrentActiveDisplay.UIDisplayOn(); //Enable the defualt UI display on PlayerMain's start method call
    }

    public void ChangeUI(AUIElement newUIDisplay) {
        /**
         * @desc If a new UI element needs to be displayed, disable the current UI element and enable the new UI element
         * @parm AUIElement $newUIDisplay - The new UI element that will be displayed to the player
        */
        _CurrentActiveDisplay.UIDisplayOff();
        _CurrentActiveDisplay = newUIDisplay;
        _CurrentActiveDisplay.UIDisplayOn();
    }

    public PlayerHUDUI GetHUDUIPlayer() {
        return _HUDUIPlayer;
    }

    public PlayerGameMenuUI GetGameMenuUIPlayer(){
        return _GameMenuUIPlayer;
    }
}
