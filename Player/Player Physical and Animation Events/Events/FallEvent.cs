using UnityEngine;

public class FallEvent : IPlayerEvent {
    private GravityMovement _GravityMovement;
    public FallEvent(Rigidbody playerRigidbody) {
        _GravityMovement = new GravityMovement(playerRigidbody);
    }

    public void ExecuteEvent() {
        _GravityMovement.ApplyGravity();
    }
}
