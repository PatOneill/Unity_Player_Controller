using UnityEngine;

public class Event_Crouch : IEvent {
    private PEvent_Crouch _CrouchPhysicsEvent;

    public Event_Crouch(PlayerPhysicsController playerPhysicsController, PlayerAnimationController playerAnimationController) {
        _CrouchPhysicsEvent = new PEvent_Crouch(playerPhysicsController);
    }

    public void CurrentEventPhysics() {
        /**
         * @desc Execute both the animation and physical events that are associated with crouching
        */
        Debug.Log("Crouch");
    }

    public void CurrentEventAnimationStart() {
        //throw new System.NotImplementedException();
        return;
    }

    public void CurrentEventAnimationStop() {
        //throw new System.NotImplementedException();
        return;
    }
}
