public class Strategy_NavigateSubWindowIgnore : IUISubWindowNavigation {

    public void SetupElementNavigation(IUISubWindowNavigation leftElement = null, IUISubWindowNavigation rightElement = null) {
        /*
         *@Desc: Since this class ignores all incoming request, there is no need to initialize the left and right element
        */
        return;
    }

    public void NavigateLeft() {
        /*
         *@Desc: If a display implements this class, ignore any sub window navigation request related to UI sub window navigation
        */
        return;
    }

    public void NavigateRight() {
        /*
         *@Desc: If a display implements this class, ignore any sub window navigation request related to UI sub window navigation
        */
        return;
    }

    public void SubWindowSelected() {
        /*
         *@Desc: If a display implements this class, ignore any sub window navigation request related to UI sub window navigation
        */
        return;
    }

    public void SubWindowUnselected() {
        /*
         *@Desc: If a display implements this class, ignore any sub window navigation request related to UI sub window navigation
        */
        return;
    }
}
