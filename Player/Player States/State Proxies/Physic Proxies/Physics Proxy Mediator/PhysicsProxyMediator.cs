using UnityEngine;

public class PhysicsProxyMediator : IPhysicsProxyJumpMediator {
    private IStateProxyOff _ProxyJump;

    public IStateProxyOff ProxyJump { set => _ProxyJump = value; }

    public PhysicsProxyMediator() {
        _ProxyJump = null;
    }

    public void CancelJumpProxy() {
        _ProxyJump.ProxyOff();
    }
}
