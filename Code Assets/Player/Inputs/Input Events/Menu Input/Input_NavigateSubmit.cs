public class Input_NavigateSubmit {
    private PlayerUIController _UIControllerPlayer;

    public Input_NavigateSubmit(PlayerUIController uiController) {
        _UIControllerPlayer = uiController;
    }

    public void InputStart() {
        /**
          * @desc Informs the player's UI controller that the player is attempting to submit a request to a UI element 
        */
        _UIControllerPlayer.NavigationInputsUI.NavigateSubmit();
    }

    public void InputEnd() {

    }
}
