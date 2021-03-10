using UnityEngine;

public class PlayerMain : MonoBehaviour {
    private PlayerMainFacade _MainFacadePlayer;

    private void Awake() {
        _MainFacadePlayer = new PlayerMainFacade(this.gameObject.GetComponent<Rigidbody>(), this.gameObject.GetComponent<Animator>(), this.gameObject.GetComponentInChildren<Camera>(), this.gameObject.GetComponentInChildren<UnityUIFunctionalityController>());
    }

    private void Start() {
        _MainFacadePlayer.FacadeStart();
    }

    private void FixedUpdate() {
        _MainFacadePlayer.FacadeFixedUpdate();
    }

    private void Update() {
        _MainFacadePlayer.FacadeUpdate();
    }

    private void LateUpdate() {
        _MainFacadePlayer.FacadeLateUpdate();
    }
}
