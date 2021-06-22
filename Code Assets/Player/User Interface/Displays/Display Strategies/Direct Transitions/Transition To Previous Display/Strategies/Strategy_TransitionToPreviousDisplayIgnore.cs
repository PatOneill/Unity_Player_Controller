public class Strategy_TransitionToPreviousDisplayIgnore : ITransitionToPreviousDisplay {
    public void TransitionToBack() {
        /*
         *@Desc: If a display implements this class, ignore any transition request to the previous display utilizing this method
        */
        return;
    }
}
