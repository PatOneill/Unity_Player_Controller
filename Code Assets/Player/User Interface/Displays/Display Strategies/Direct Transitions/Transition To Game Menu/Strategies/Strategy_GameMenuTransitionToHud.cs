public class Strategy_GameMenuTransitionToHud : ITransitionToGameMenu {
    private UI_DisplayTransitions _DisplayTransitions;
    public Strategy_GameMenuTransitionToHud(UI_DisplayTransitions displayTransitions) {
        _DisplayTransitions = displayTransitions;
    }

    public void TransitionToGameMenu() {
        /*
         *@Desc: If a display implements this class, allow this display to transitions to the Hud
        */
        _DisplayTransitions.TransitionToHud();
    }
}
