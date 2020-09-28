public interface IDynamicProxy {
    void CheckActivation();
    void ActiveProxy();
    void DeactivateProxy();
    void SendRequest();
    void RetractRequest();
}
