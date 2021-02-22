using UnityEngine;

public class Event_Idle : IEvent {
    private PEvent_Idle _IdlePhysicsEvent;
    public Event_Idle(PlayerPhysicsController playerPhysicsController) {
        _IdlePhysicsEvent = new PEvent_Idle(playerPhysicsController);
    }

    public void ExecuteEvent() {
        Debug.Log("Idle");
        _IdlePhysicsEvent.ExecutePhysicsEvent();
    }
}
