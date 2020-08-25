using UnityEngine;

public class IdleEvent : IPlayerEvent {
    private Rigidbody _PlayerRigidbody;
    public IdleEvent(Rigidbody playerRigidbody) {
        _PlayerRigidbody = playerRigidbody;
    }

    public void ExecuteEvent() {
        //_PlayerRigidbody.velocity = Vector3.zero;
    }
}
