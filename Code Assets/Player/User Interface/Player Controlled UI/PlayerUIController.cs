public class PlayerUIController {
    private UnityUIController _UIControllerUnity;
    private PlayerHUDController _HUDControllerPlayer;

    public PlayerUIController(UnityUIController unityUI) {
        _UIControllerUnity = unityUI;
        _HUDControllerPlayer = new PlayerHUDController();
    }

    public void SetUIElements() {
        /**
         * @desc Sets all player related UI elements in the start method of the player class. 
         * NOTE: This is done because we can't be sure that unity will always execute UnityUIController's Awake method before PlayerMain's Awake method
        */
        _HUDControllerPlayer.HUDControllerUnity = _UIControllerUnity.GetUnityHUDController();
    }

    public PlayerHUDController GetHudControllerPlayer() {
        return _HUDControllerPlayer;
    }
}
