using UnityEngine;

public class UnityUIFunctionalityController : MonoBehaviour {
    private UnityHUDFunctionality _HudFunctionalityUnity;
    private UnityGameMenuFunctionality _GameMenuFunctionalityUnity;

    private void Awake() {
        _HudFunctionalityUnity = new UnityHUDFunctionality(this.gameObject);
        _GameMenuFunctionalityUnity = new UnityGameMenuFunctionality(this.gameObject);
    }

    public UnityHUDFunctionality GetUnityHUDController() {
        return _HudFunctionalityUnity;
    }

    public UnityGameMenuFunctionality GetUnityGameMenuController() {
        return _GameMenuFunctionalityUnity;
    }
}
