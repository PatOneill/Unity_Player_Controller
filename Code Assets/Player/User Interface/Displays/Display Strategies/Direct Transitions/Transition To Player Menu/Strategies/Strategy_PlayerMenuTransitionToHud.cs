public class Strategy_PlayerMenuTransitionToHud : ITransitionToPlayerMenu {
    private UI_DisplayTransitions _DisplayTransitions;
    public Strategy_PlayerMenuTransitionToHud(UI_DisplayTransitions displayTransitions) {
        _DisplayTransitions = displayTransitions;
    }

    public void TransitionToPlayerMenu() {
        /*
         *@Desc: If a display implements this class, allow this display to transitions to the Hud
        */
        _DisplayTransitions.TransitionToHud();
    }
}
