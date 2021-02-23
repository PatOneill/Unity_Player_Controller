using UnityEngine;

public class Event_Crouch : IEvent {
    private PEvent_Crouch _CrouchPhysicsEvent;

    public Event_Crouch(PlayerPhysicsController playerPhysicsController) {
        _CrouchPhysicsEvent = new PEvent_Crouch(playerPhysicsController);
    }

    public void ExecuteEvent() {
        /**
         * @desc Execute both the animation and physical events that are associated with crouching
        */
        Debug.Log("Crouch");
    }
}
