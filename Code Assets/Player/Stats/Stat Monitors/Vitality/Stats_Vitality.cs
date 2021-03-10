public class Stats_Vitality {
    private float _CurrentHealth;
    private float _MaxHealth;
    private float _HealthRecoveryAmount;
    private float _HealthRecoveryTime;
    private float _TimeSinceLastDecreaseInHealth;
    private PlayerHUDUI _HUDUIPlayer;

    public Stats_Vitality(PlayerHUDUI hudController) {
        _CurrentHealth = 100.0f;
        _MaxHealth = 100.0f;
        _HealthRecoveryAmount = 1.0f;
        _HealthRecoveryTime = 0.5f;
        _TimeSinceLastDecreaseInHealth = 0.0f;
        _HUDUIPlayer = hudController;
    }
}
