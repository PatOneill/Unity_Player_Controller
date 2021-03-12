public class PlayerStatsController {
    private Stats_Agility _AgilityStats;
    private Stats_Vitality _VitalityStats;

    public Stats_Agility GetAgilityStats() { return _AgilityStats; }

    public PlayerStatsController(PlayerUIController uiController) {
        _AgilityStats = new Stats_Agility(uiController);
        _VitalityStats = new Stats_Vitality(uiController);
    }

    public void AutoStatRecovery() {
        /**
         * @desc As time progresses in game, check to see if any of the player stats should enter a state of recovery
        */
        _AgilityStats.StaminaRecoverOverTime();
    }
}
