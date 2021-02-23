using UnityEngine;

public class Event_Sprint : IEvent {
    private PEvent_Sprint _SprintPhysicsEvent;
    private Stat_Sprint _SprintStat;

    public Event_Sprint(PlayerStatsController statsController, PlayerPhysicsController playerPhysicsController) {
        _SprintPhysicsEvent = new PEvent_Sprint(playerPhysicsController);
        _SprintStat = statsController.GetAgilityStats().GetSprintStat();
    }

    public void ExecuteEvent() {
        /**
         * @desc Execute both the animation and physical events that are associated with sprinting
        */
        Debug.Log("Sprint");
        _SprintStat.DecayStamina(); //Every frame the player spends sprinting lower their current stamina value by a set amount
        _SprintPhysicsEvent.ExecutePhysicsEvent(_SprintStat.GetSprintAcceleration());
    }
}
