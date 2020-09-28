public interface IStateProxy {
    void AddActiveProxy(IDynamicProxy activeProxy);
    void RemoveInactiveProxy(IDynamicProxy inactiveProxy);
    APlayerState CurrentPlayerState();
}
