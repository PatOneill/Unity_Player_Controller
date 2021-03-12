public class Input_GameMenu {
    private PlayerUIController _UIControllerPlayer;
    private PlayerInputController _InputControllerPlayer;

    public Input_GameMenu(PlayerInputController inputController, PlayerUIController uiController) {
        _InputControllerPlayer = inputController;
        _UIControllerPlayer = uiController;
    }

    public void Gameplay_InputStart() {
        /**
          * @desc Info the player UI controller that a new UI element needs to be displayed
        */
        _UIControllerPlayer.CurrentUIDisplay.TransitionToGameMenuUI();
        _InputControllerPlayer.StartMenuInputController(); //Change out the callback functions from gameplay inputs to menu inputs
    }

    public void Menu_InputStart() {
        /**
          * @desc Info the player UI controller that a new UI element needs to be displayed
        */
        _UIControllerPlayer.CurrentUIDisplay.TransitionToGameMenuUI();
        _InputControllerPlayer.StartGamePlayInuptController(); //Change out the callback functions from menu inputs to gameplay inputs
    }
}
