public abstract class AUIElement : IPlayerUIController {
    protected PlayerUIController _UIControllerPlayer;

    public virtual void DisplayHUD() { return;  }
    public virtual void DisplayGameMenu() { return; }
    public virtual void DisplayPlayerManagementMenu() { return; }
    public virtual void DisplayItemHolderMenu() { return; }

    public abstract void UIDisplayOn();
    public abstract void UIDisplayOff();
}
