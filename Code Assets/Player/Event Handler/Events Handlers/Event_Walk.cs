using UnityEngine;

public class Event_Walk : IEvent {
    private PEvent_Walk _WalkPhysicsEvent;
    private Stat_Walk _WalkStat;

    public Event_Walk(PlayerStatsController statsController, PlayerPhysicsController playerPhysicsController) {
        _WalkPhysicsEvent = new PEvent_Walk(playerPhysicsController);
        _WalkStat = statsController.GetAgilityStats().GetWalkStat();
    }

    public void ExecuteEvent() {
        /**
         * @desc Execute both the animation and physical events that are associated with walking
        */
        Debug.Log("Walk");
        _WalkPhysicsEvent.ExecutePhysicsEvent(_WalkStat.GetWalkAcceleration());
    }
}
