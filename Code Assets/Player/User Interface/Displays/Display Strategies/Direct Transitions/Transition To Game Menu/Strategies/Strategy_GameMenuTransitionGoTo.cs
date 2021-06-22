public class Strategy_GameMenuTransitionGoTo : ITransitionToGameMenu {
    private UI_DisplayTransitions _DisplayTransitions;
    public Strategy_GameMenuTransitionGoTo(UI_DisplayTransitions displayTransitions) {
        _DisplayTransitions = displayTransitions;
    }

    public void TransitionToGameMenu() {
        /*
         *@Desc: If a display implements this class, allow this display to transitions to the game menu
        */
        _DisplayTransitions.TransitionToGameMenu();
    }
}
