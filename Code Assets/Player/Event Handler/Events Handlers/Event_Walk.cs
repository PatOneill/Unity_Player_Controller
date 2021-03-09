using UnityEngine;

public class Event_Walk : IEvent {
    private PEvent_Walk _WalkPhysicsEvent;
    private AEvent_Walk _WalkAnimationEvent;
    private Stat_Walk _WalkStat;

    public Event_Walk(PlayerStatsController statsController, PlayerPhysicsController playerPhysicsController, PlayerAnimationController playerAnimationController) {
        _WalkPhysicsEvent = new PEvent_Walk(playerPhysicsController);
        _WalkAnimationEvent = new AEvent_Walk(playerAnimationController);
        _WalkStat = statsController.GetAgilityStats().GetWalkStat();
    }

    public void CurrentEventPhysics() {
        /**
         * @desc Execute both the animation and physical events that are associated with walking
        */
        Debug.Log("Walk");
        _WalkPhysicsEvent.ExecutePhysicsEvent(_WalkStat.GetWalkAcceleration());
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
