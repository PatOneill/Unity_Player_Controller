public class Stats_Vitality {
    private float _CurrentHealth;
    private float _MaxHealth;
    private float _HealthRecoveryAmount;
    private float _HealthRecoveryTime;
    private float _TimeSinceLastDecreaseInHealth;
    private UI_HudFunctionality _HudFunctionality;

    public Stats_Vitality(PlayerUIController uiController) {
        _CurrentHealth = 100.0f;
        _MaxHealth = 100.0f;
        _HealthRecoveryAmount = 1.0f;
        _HealthRecoveryTime = 0.5f;
        _TimeSinceLastDecreaseInHealth = 0.0f;
        _HudFunctionality = uiController.GetHudControllerUI().GetHudFunctionalityUI();
    }
}
