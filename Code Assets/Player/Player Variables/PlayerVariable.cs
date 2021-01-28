public class PlayerVariable {

    private readonly PlayerHealth _HealthPlayer;

    public PlayerVariable() {
        _HealthPlayer = new PlayerHealth();
    }

    public float GetPlayersHealthPercentage() {
        return _HealthPlayer.TotalHealthPercentage();
    }
}
