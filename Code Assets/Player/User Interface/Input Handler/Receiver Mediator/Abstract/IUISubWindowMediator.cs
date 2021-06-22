public interface IUISubWindowMediator {
    IUIActiveReceiver SetSubWindowReceiver {
        set;
    }
    void SubWindowActive();
    void SubWindowInactive();
}
