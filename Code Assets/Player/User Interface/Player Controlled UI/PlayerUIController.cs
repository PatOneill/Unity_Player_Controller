using UnityEngine;

public class PlayerUIController {
    private AUIController _CurrentUIDisplay;
    private UI_HudController _HudControllerUI;
    private UI_GameMenuController _GameMenuControllerUI;

    public AUIController CurrentUIDisplay { get => _CurrentUIDisplay; }

    public PlayerUIController(GameObject playerUI) {
        _HudControllerUI = new UI_HudController(playerUI, this);
        _GameMenuControllerUI = new UI_GameMenuController(playerUI, this);
        _CurrentUIDisplay = _HudControllerUI; //Display the default UI element to the player
        _CurrentUIDisplay.UIDisplayOn();
    }

    public void ChangePlayerUIDisplay(AUIController newUIDisplay) {
        _CurrentUIDisplay.UIDisplayOff();
        _CurrentUIDisplay = newUIDisplay;
        _CurrentUIDisplay.UIDisplayOn();
    }

    public UI_HudController GetHudControllerUI() {
        return _HudControllerUI;
    }

    public UI_GameMenuController GetGameMenuControllerUI() {
        return _GameMenuControllerUI;
    }
}
