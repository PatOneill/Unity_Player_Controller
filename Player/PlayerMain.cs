using UnityEngine;

public class PlayerMain : MonoBehaviour {
    private Rigidbody _PlayerRigidbody;
    private Camera _PlayerCamera;
    private PlayerFacade _FacadePlayer;

    private void Awake() {
        _PlayerRigidbody = this.gameObject.GetComponent<Rigidbody>();
        _PlayerCamera = this.gameObject.GetComponentInChildren<Camera>();

        _FacadePlayer = new PlayerFacade(_PlayerRigidbody, _PlayerCamera);
    }

    private void Start() {
        return;
    }

    private void FixedUpdate() {
        _FacadePlayer.FacadeFixedUpdate();
    }

    private void Update() {
        _FacadePlayer.FacadeUpdate();
    }

    private void LateUpdate() {
        _FacadePlayer.FacadeLastUpdate();
    }
}
