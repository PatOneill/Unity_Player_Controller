using UnityEngine;

public class PlayerIdleEvent : IPlayerEvent {
    public PlayerIdleEvent() {

    }

    public void ExecuteAnimationEvent() {
        throw new System.NotImplementedException();
    }

    public void ExecutePhysicsEvent() {
        return;
    }
}
