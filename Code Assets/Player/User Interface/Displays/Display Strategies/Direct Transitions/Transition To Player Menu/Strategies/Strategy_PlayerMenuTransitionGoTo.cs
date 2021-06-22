public class Strategy_PlayerMenuTransitionGoTo : ITransitionToPlayerMenu {
    private UI_DisplayTransitions _DisplayTransitions;
    public Strategy_PlayerMenuTransitionGoTo(UI_DisplayTransitions displayTransitions) {
        _DisplayTransitions = displayTransitions;
    }

    public void TransitionToPlayerMenu() {
        /*
         *@Desc: If a display implements this class, allow this display to transitions to the player menu
        */
        _DisplayTransitions.TransitionToPlayerMenu();
    }
}
