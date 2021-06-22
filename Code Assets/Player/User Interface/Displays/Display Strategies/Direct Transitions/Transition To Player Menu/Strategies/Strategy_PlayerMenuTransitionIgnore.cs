public class Strategy_PlayerMenuTransitionIgnore : ITransitionToPlayerMenu {
    public void TransitionToPlayerMenu() {
        /*
         *@Desc: If a display implements this class, ignore any transition request to player menu that utilizes this method
        */
        return;
    }
}
