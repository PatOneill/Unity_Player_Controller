using UnityEngine;
using UnityEngine.UI;

public class PlayerUIController : MonoBehaviour
{
    [SerializeField] private GameObject _PlayerHUD;
    [SerializeField] private GameObject _PlayerGameMenu;
    [SerializeField] private GameObject _PlayerHealthSlider;
    
    private Slider _HealthSlider;

    public Slider HealthSlider { get => _HealthSlider; }

    private void Awake() {
        _HealthSlider = _PlayerHealthSlider.GetComponent<Slider>();
    }
}
