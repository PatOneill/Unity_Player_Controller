using UnityEngine;

public class UI_GameMenuController : AUIController {
    private PlayerUIController _UIControllerPlayer;
    private UI_GameMenuFunctionality _GameMenuFunctionalityUI;

    public UI_GameMenuController(GameObject canvasObject, PlayerUIController uiController) {
        _UnityUIDisplay = canvasObject.transform.Find("Player Game Menu").gameObject;
        _UIControllerPlayer = uiController;
        _GameMenuFunctionalityUI = new UI_GameMenuFunctionality(_UnityUIDisplay);
        _UINavigationCommands = new UI_GameMenuNavigation(_GameMenuFunctionalityUI);
    }

    public override void TransitionToHudUI() {
        _UIControllerPlayer.ChangePlayerUIDisplay(_UIControllerPlayer.GetHudControllerUI());
    }

    public override void TransitionToGameMenuUI() {
        _UIControllerPlayer.ChangePlayerUIDisplay(_UIControllerPlayer.GetHudControllerUI());
    }
}
