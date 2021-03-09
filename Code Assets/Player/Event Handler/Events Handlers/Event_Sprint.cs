using UnityEngine;

public class Event_Sprint : IEvent {
    private PEvent_Sprint _SprintPhysicsEvent;
    private AEvent_Sprint _SprintAnimationEvent;
    private Stat_Sprint _SprintStat;

    public Event_Sprint(PlayerStatsController statsController, PlayerPhysicsController playerPhysicsController, PlayerAnimationController playerAnimationController) {
        _SprintPhysicsEvent = new PEvent_Sprint(playerPhysicsController);
        _SprintAnimationEvent = new AEvent_Sprint(playerAnimationController);
        _SprintStat = statsController.GetAgilityStats().GetSprintStat();
    }

    public void CurrentEventPhysics() {
        /**
         * @desc Execute both the animation and physical events that are associated with sprinting
        */
        Debug.Log("Sprint");
        _SprintStat.DecayStamina(); //Every frame the player spends sprinting lower their current stamina value by a set amount
        _SprintPhysicsEvent.ExecutePhysicsEvent(_SprintStat.GetSprintAcceleration());
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
