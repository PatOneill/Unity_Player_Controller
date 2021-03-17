using UnityEngine;

public class UI_GameMenuController : AUIController {
    private PlayerUIController _UIControllerPlayer;
    private UI_GameMenuFunctionality _GameMenuFunctionalityUI;

    public UI_GameMenuController(GameObject canvasObject, PlayerUIController uiController) {
        _UnityUIDisplay = canvasObject.transform.Find("Player Game Menu").gameObject;
        _UIControllerPlayer = uiController;
        _GameMenuFunctionalityUI = new UI_GameMenuFunctionality(_UnityUIDisplay);
    }

    public override void TransitionToHudUI() {
        _UIControllerPlayer.ChangePlayerUIDisplay(_UIControllerPlayer.GetHudControllerUI());
    }

    public override void TransitionToGameMenuUI() {
        _UIControllerPlayer.ChangePlayerUIDisplay(_UIControllerPlayer.GetHudControllerUI());
    }

    public override void NavigateVertically(int direction) {
        if(direction < 0) {
            _GameMenuFunctionalityUI.CurrentSelectedUIElement.ShiftDown();
        } else {
            _GameMenuFunctionalityUI.CurrentSelectedUIElement.ShiftUp();
        }
    }

    public override void NavigateHorizontally(int direction) {
        if (direction < 0) {
            _GameMenuFunctionalityUI.CurrentSelectedUIElement.ShiftLeft();
        } else {
            _GameMenuFunctionalityUI.CurrentSelectedUIElement.ShiftRight();
        }
    }

    public override void NavigateSelectablePressed() {
        return;
    }

    public override void UIDisplayOn() {
        /**
          * @desc Enables a unity UI gameobject
        */
        _GameMenuFunctionalityUI.SetDefaultSelected();
        _UnityUIDisplay.SetActive(true);
    }

    public override void UIDisplayOff() {
        /**
          * @desc Disables a unity UI gameobject
        */
        _UnityUIDisplay.SetActive(false);
    }
}
