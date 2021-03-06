using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    private PlayerMainFacade _MainFacadePlayer;

    private void Awake() {
        GameObject userInterface = this.gameObject.transform.Find("Player User Interface").gameObject;
        _MainFacadePlayer = new PlayerMainFacade(userInterface);
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
