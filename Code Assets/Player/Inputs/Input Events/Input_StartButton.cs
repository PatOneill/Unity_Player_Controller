public class Input_StartButton {
    private PlayerUIController _UIControllerPlayer;
    private PlayerInputController _InputControllerPlayer;

    public Input_StartButton(PlayerUIController uiController, PlayerInputController inputController) {
        _UIControllerPlayer = uiController;
        _InputControllerPlayer = inputController;
    }

    public void GamePlay_InputStart() {
        /**
          * @desc Info the player UI controller that a new UI element needs to be displayed
        */
        _UIControllerPlayer.CurrentActiveDisplay.DisplayGameMenu();
        _InputControllerPlayer.StartMenuInputController(); //Change out the callback functions from gameplay inputs to menu inputs
    }

    public void Menu_InputStart() {
        /**
          * @desc Info the player UI controller that a new UI element needs to be displayed
        */
        _UIControllerPlayer.CurrentActiveDisplay.DisplayGameMenu();
        _InputControllerPlayer.StartGamePlayInuptController(); //Change out the callback functions from menu inputs to gameplay inputs
    }
}
