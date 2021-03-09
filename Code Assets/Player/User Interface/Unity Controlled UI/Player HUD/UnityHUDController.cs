using UnityEngine;
using UnityEngine.UI;

public class UnityHUDController : IUnityUIController {
    private GameObject _PlayerHUD;
    private Slider _HealthBarSlider;
    private Slider _StaminaSlider;

    public UnityHUDController(GameObject canvasObject) {
        _PlayerHUD = canvasObject.transform.Find("Player HUD").gameObject;
        _HealthBarSlider = _PlayerHUD.transform.Find("Health Bar").GetComponent<Slider>();
        _StaminaSlider = _PlayerHUD.transform.Find("Stamina Bar").GetComponent<Slider>();
    }

    public void UpdateHealthBarSlider(float newPercentage) {
        /**
          * @desc As the player's health value changes, update the slider to correctly represent the player's remaining health percentage
          * @parm float $newPercentage - represents the remaining amount of stamina as a percentage
        */
        _HealthBarSlider.value = newPercentage;
    }

    public void UpdateStaminaBarSlider(float newPercentage) {
        /**
          * @desc As the player's stamina value changes, update the slider to correctly represent the player's remaining stamina percentage
          * @parm float $newPercentage - represents the remaining amount of stamina as a percentage
        */
        _StaminaSlider.value = newPercentage;
    }

    public void UIDisplayOn() {
        /**
          * @desc Re-enable the player's HUD display and script functionality
        */
        _PlayerHUD.SetActive(true);
    }

    public void UIDisplayOff() {
        /**
          * @desc Disable the player's HUD display and script functionality
        */
        _PlayerHUD.SetActive(false);
    }
}
