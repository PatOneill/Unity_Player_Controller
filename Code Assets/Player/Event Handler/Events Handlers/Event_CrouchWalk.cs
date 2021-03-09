using UnityEngine;

public class Event_CrouchWalk : IEvent {
    private PEvent_CrouchWalk _CrouchWalkPhysicsEvent;
    private Stat_CrouchWalk _CrouchWalkStat;

    public Event_CrouchWalk(PlayerStatsController statsController, PlayerPhysicsController playerPhysicsController, PlayerAnimationController playerAnimationController) {
        _CrouchWalkPhysicsEvent = new PEvent_CrouchWalk(playerPhysicsController);
        _CrouchWalkStat = statsController.GetAgilityStats().GetCrouchWalkStat();
    }

    public void CurrentEventPhysics() {
        /**
         * @desc Execute both the animation and physical events that are associated with crouch walking
        */
        Debug.Log("Crouching Walk");
        _CrouchWalkPhysicsEvent.ExecutePhysicsEvent(_CrouchWalkStat.GetCrouchWalkAcceleration());
    }

    public void CurrentEventAnimationStart() {
        throw new System.NotImplementedException();
    }

    public void CurrentEventAnimationStop() {
        throw new System.NotImplementedException();
    }
}
