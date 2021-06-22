public interface IUISubWindowNavigation : ILeftNavigate, IRightNavigate{
    void SetupElementNavigation(IUISubWindowNavigation leftElement = null, IUISubWindowNavigation rightElement = null);
    void SubWindowSelected();
    void SubWindowUnselected();
}
