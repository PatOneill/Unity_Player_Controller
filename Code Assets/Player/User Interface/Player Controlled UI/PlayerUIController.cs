using UnityEngine;

public class PlayerUIController  {
    private AUIController _CurrentUIDisplay;
    private UINavigationInputs _NavigationInputsUI;
    private UI_HudController _HudControllerUI;
    private UI_GameMenuController _GameMenuControllerUI;

    public IUITransitionCommands CurrentUIDisplay { get => _CurrentUIDisplay; }
    public UINavigationInputs NavigationInputsUI { get => _NavigationInputsUI; }

    public PlayerUIController(GameObject playerUI) {
        _HudControllerUI = new UI_HudController(playerUI, this);
        _GameMenuControllerUI = new UI_GameMenuController(playerUI, this);
        _NavigationInputsUI = new UINavigationInputs();
        _CurrentUIDisplay = _HudControllerUI; //Display the default UI element to the player
        _NavigationInputsUI.CurrentUIDisplay = _CurrentUIDisplay; //Set the player's ui navigation commands to respond to the current active only
        _CurrentUIDisplay.UIDisplayOn();
    }

    public void ChangePlayerUIDisplay(AUIController newUIDisplay) {
        /**
          * @desc This method handles the state transitions of the current active UI upon particular request from the player's input device
          * @parm AUIController $newUIDisplay - The UI display that needs to be changed out for the old display
        */
        _CurrentUIDisplay.UIDisplayOff();
        _CurrentUIDisplay = newUIDisplay;
        _NavigationInputsUI.CurrentUIDisplay = _CurrentUIDisplay; //Set the player's ui navigation commands to respond to the current active only
        _CurrentUIDisplay.UIDisplayOn();
    }

    public UI_HudController GetHudControllerUI() {
        return _HudControllerUI;
    }

    public UI_GameMenuController GetGameMenuControllerUI() {
        return _GameMenuControllerUI;
    }
}
