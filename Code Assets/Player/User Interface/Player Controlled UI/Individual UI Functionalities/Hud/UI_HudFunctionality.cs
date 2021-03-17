using UnityEngine;
using UnityEngine.UI;

public class UI_HudFunctionality {
    private Slider _HealthBarSlider;
    private Slider _StaminaSlider;

    public UI_HudFunctionality(GameObject playerHud) {
        _HealthBarSlider = playerHud.transform.Find("HUD_HealthBar").GetComponent<Slider>();
        _StaminaSlider = playerHud.transform.Find("HUD_StaminaBar").GetComponent<Slider>();
    }

    public void IncreaseHealthBar(float newPercentage) {
        /**
          * @desc As the player's health value increases, update the slider to correctly represent the player's remaining health percentage
          * @parm float $newPercentage - represents the remaining amount of stamina as a percentage
        */
        _HealthBarSlider.value = newPercentage;
    }

    public void DecreaseHealthBar(float newPercentage) {
        /**
          * @desc As the player's health value decreases, update the slider to correctly represent the player's remaining health percentage
          * @parm float $newPercentage - represents the remaining amount of stamina as a percentage
        */
        _HealthBarSlider.value = newPercentage;
    }

    public void IncreaseStaminaBar(float newPercentage) {
        /**
          * @desc As the player's stamina value increases, update the slider to correctly represent the player's remaining stamina percentage
          * @parm float $newPercentage - represents the remaining amount of stamina as a percentage
        */
        _StaminaSlider.value = newPercentage;
    }

    public void DecreaseStaminaBar(float newPercentage) {
        /**
          * @desc As the player's stamina value decreases, update the slider to correctly represent the player's remaining stamina percentage
          * @parm float $newPercentage - represents the remaining amount of stamina as a percentage
        */
        _StaminaSlider.value = newPercentage;
    }
}
