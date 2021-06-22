public interface IUIElementNavigation : ILeftNavigate, IRightNavigate, IUpNavigate, IDownNavigate {
    void ElementSelected();
    void ElementUnselected();
}
