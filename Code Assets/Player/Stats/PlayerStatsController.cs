public class PlayerStatsController {
    private Stats_Agility _AgilityStats;

    public Stats_Agility GetAgilityStats() { return _AgilityStats; }

    public PlayerStatsController() {
        _AgilityStats = new Stats_Agility();
    }

    public void AutoStatRecovery() {
        /**
         * @desc As time progresses in game, check to see if any of the player stats should enter a state of recovery
        */
        _AgilityStats.StaminaRecoverOverTime();
    }
}
