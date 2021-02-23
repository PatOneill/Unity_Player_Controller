using UnityEngine;

public class Event_CrouchWalk : IEvent {
    private PEvent_CrouchWalk _CrouchWalkPhysicsEvent;
    private Stat_CrouchWalk _CrouchWalkStat;

    public Event_CrouchWalk(PlayerStatsController statsController, PlayerPhysicsController playerPhysicsController) {
        _CrouchWalkPhysicsEvent = new PEvent_CrouchWalk(playerPhysicsController);
        _CrouchWalkStat = statsController.GetAgilityStats().GetCrouchWalkStat();
    }

    public void ExecuteEvent() {
        /**
         * @desc Execute both the animation and physical events that are associated with crouch walking
        */
        Debug.Log("Crouching Walk");
        _CrouchWalkPhysicsEvent.ExecutePhysicsEvent(_CrouchWalkStat.GetCrouchWalkAcceleration());
    }
}
