public class PlayerUI {
    private readonly PlayerUIController _PlayerUIElementController;
    private readonly PlayerVariable _VariablesPlayer;

    public PlayerUI(PlayerVariable playerVariable, PlayerUIController playerUIController) {
        _VariablesPlayer = playerVariable;
        _PlayerUIElementController = playerUIController;
    }

    public void UpdateUIDisplay() {
        _PlayerUIElementController.HealthSlider.value = _VariablesPlayer.GetPlayersHealthPercentage();
    }

    public void OpenGameMenu() {

    }

    public void CloseGameMenu() {

    }

    public void OpenSettingsMenu() {

    }

    public void CloseSettingsMenu() {

    }
}
