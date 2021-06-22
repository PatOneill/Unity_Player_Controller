public class Strategy_GameMenuTransitionIgnore : ITransitionToGameMenu {
    public void TransitionToGameMenu() {
        /*
         *@Desc: If a display implements this class, ignore any transition request to game menu that utilizes this method
        */
        return;
    }
}
