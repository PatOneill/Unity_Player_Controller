public interface IUINavigationMediator {
    IUIActiveReceiver SetNavigationReceiver {
        set;
    }
    void NavigationActive();
    void NavigationInactive();
}
