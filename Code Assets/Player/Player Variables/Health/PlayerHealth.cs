using System.Collections.Generic;

public class PlayerHealth {
    private float _BasePlayerMaxHealth;

    private float _VisualPlayerMaxHealth;
    private float _VisualPlayerCurrentHealth;

    public PlayerHealth() {
        _BasePlayerMaxHealth = 100.0f;
        _VisualPlayerMaxHealth = 100.0f;
        _VisualPlayerCurrentHealth = 50.0f;
    }

    public float TotalHealthPercentage() {
        float percentage = _VisualPlayerCurrentHealth / _VisualPlayerMaxHealth;
        if( percentage < 0f) {
            percentage = 0f;
        }
        return percentage;
    }
}
