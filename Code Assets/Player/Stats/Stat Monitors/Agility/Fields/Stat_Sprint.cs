public class Stat_Sprint {
    private Stats_Agility _AgilityStats;
    private float _SprintAcceleration;
    private float _SprintStaminaCost;
    private Mediator_Proxies _ProxiesMediator;

    public Mediator_Proxies ProxiesMediator { set => _ProxiesMediator = value; }

    public float GetSprintAcceleration() { return _SprintAcceleration; }

    public Stat_Sprint(Stats_Agility agilityStats) {
        _SprintAcceleration = 6.0f;
        _SprintStaminaCost = 0.5f;
        _AgilityStats = agilityStats;
        _ProxiesMediator = null;
    }

    public bool CheckStaminaCostSprint() {
        /**
         * @desc A check to see if the player has enough stamina to enter the sprint state
        */
        return _AgilityStats.IsThereEnoughStamina(_SprintStaminaCost);
    }

    public void DecayStamina() {
        /**
         * @desc Send a request to lower the stamina value by the set amount and check to see i
        */
        bool isThereEnoughStamina = _AgilityStats.LowerStamina(_SprintStaminaCost);
        if (!isThereEnoughStamina) {
            _ProxiesMediator.KillSprintProxy();
        }   
    }
}
