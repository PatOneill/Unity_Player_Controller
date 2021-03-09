using UnityEngine;

public class UnityUIController : MonoBehaviour {
    private UnityHUDController _HudControllerUnity;

    private void Awake() {
        _HudControllerUnity = new UnityHUDController(this.gameObject);
    }

    public UnityHUDController GetUnityHUDController() {
        return _HudControllerUnity;
    }
}
