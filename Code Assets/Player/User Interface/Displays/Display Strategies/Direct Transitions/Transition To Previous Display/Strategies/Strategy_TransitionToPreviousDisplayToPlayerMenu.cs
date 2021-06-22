public class Strategy_TransitionToPreviousDisplayToPlayerMenu : ITransitionToPreviousDisplay {
    private UI_DisplayTransitions _DisplayTransitions;
    public Strategy_TransitionToPreviousDisplayToPlayerMenu(UI_DisplayTransitions displayTransitions) {
        _DisplayTransitions = displayTransitions;
    }
    public void TransitionToBack() {
        /*
         *@Desc: If a display implements this class, allow this display to transitions back to the player menu
        */
        _DisplayTransitions.TransitionToPlayerMenu();
    }
}
