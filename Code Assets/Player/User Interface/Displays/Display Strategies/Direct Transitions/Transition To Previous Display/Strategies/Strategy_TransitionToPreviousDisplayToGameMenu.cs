public class Strategy_TransitionToPreviousDisplayToGameMenu : ITransitionToPreviousDisplay {
    private UI_DisplayTransitions _DisplayTransitions;
    public Strategy_TransitionToPreviousDisplayToGameMenu(UI_DisplayTransitions displayTransitions) {
        _DisplayTransitions = displayTransitions;
    }
    public void TransitionToBack() {
        /*
         *@Desc: If a display implements this class, allow this display to transitions back to the game menu
        */
        _DisplayTransitions.TransitionToGameMenu();
    }
}
