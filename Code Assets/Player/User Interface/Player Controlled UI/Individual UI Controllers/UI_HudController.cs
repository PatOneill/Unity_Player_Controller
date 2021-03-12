using UnityEngine;

public class UI_HudController : AUIController {
    private PlayerUIController _UIControllerPlayer;
    private UI_HudFunctionality _HudFunctionalityUI;

    public UI_HudController(GameObject canvasObject, PlayerUIController uiController) {
        _UnityUIDisplay = canvasObject.transform.Find("Player HUD").gameObject;
        _UIControllerPlayer = uiController;
        _HudFunctionalityUI = new UI_HudFunctionality(_UnityUIDisplay);
        _UINavigationCommands = new UI_HudNavigation(_HudFunctionalityUI);
    }

    public UI_HudFunctionality GetHudFunctionalityUI() {
        return _HudFunctionalityUI;
    }

    public override void TransitionToGameMenuUI() {
        _UIControllerPlayer.ChangePlayerUIDisplay(_UIControllerPlayer.GetGameMenuControllerUI());
    }
}
