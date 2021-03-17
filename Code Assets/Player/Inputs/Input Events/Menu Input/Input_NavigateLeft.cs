public class Input_NavigateLeft {
    private PlayerUIController _UIControllerPlayer;

    public Input_NavigateLeft(PlayerUIController uiController) {
        _UIControllerPlayer = uiController;
    }

    public void InputStart(float direction) {
        /**
          * @desc Informs the player's UI controller that the player is attempting to select a UI element that is located to the left of the current selected UI element
          * @parm float $direction - Since this input is tide to both a button and a analog stick, the direction is used to check to see how far left the analog stick has been moved
        */
        _UIControllerPlayer.NavigationInputsUI.NavigateLeft();
    }

    public void InputEnd() {

    }
}
