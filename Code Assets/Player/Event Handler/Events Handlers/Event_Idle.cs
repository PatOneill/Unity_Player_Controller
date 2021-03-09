using UnityEngine;

public class Event_Idle : IEvent {
    private PEvent_Idle _IdlePhysicsEvent;
    private AEvent_Idle _IdleAnimationEvent;

    public Event_Idle(PlayerPhysicsController playerPhysicsController, PlayerAnimationController playerAnimationController) {
        _IdlePhysicsEvent = new PEvent_Idle(playerPhysicsController);
        _IdleAnimationEvent = new AEvent_Idle(playerAnimationController);
    }

    public void CurrentEventPhysics() {
        /**
         * @desc Execute both the animation and physical events that are associated with the idle event
        */
        Debug.Log("Idle");
        _IdlePhysicsEvent.ExecutePhysicsEvent();
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
