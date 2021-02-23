public class Stat_Sprint {
    private Stats_Agility _AgilityStats;
    private float _SprintAcceleration;
    private float _SprintStaminaCost;

    public float GetSprintAcceleration() { return _SprintAcceleration; }

    public Stat_Sprint(Stats_Agility agilityStats) {
        _SprintAcceleration = 6.0f;
        _SprintStaminaCost = 0.1f;
        _AgilityStats = agilityStats;
    }

    public bool CheckStaminaCostSprint() {
        /**
         * @desc A check to see if the player has enough stamina to enter the sprint state
        */
        return _AgilityStats.IsThereEnoughStamina(_SprintStaminaCost);
    }

    public void DecayStamina() {
        /**
         * @desc Send a request to lower the stamina value by the set amount
        */
        _AgilityStats.LowerStamina(_SprintStaminaCost);
    }
}
