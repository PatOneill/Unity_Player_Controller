public class Strategy_TransitionToPreviousDisplayToHud : ITransitionToPreviousDisplay {
    private UI_DisplayTransitions _DisplayTransitions;
    public Strategy_TransitionToPreviousDisplayToHud(UI_DisplayTransitions displayTransitions) {
        _DisplayTransitions = displayTransitions;
    }
    public void TransitionToBack() {
        /*
         *@Desc: If a display implements this class, allow this display to transitions back to the Hud
        */
        _DisplayTransitions.TransitionToHud();
    }
}
