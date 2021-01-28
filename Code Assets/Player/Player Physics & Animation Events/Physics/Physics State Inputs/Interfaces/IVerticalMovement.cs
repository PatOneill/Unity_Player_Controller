using UnityEngine;

public interface IVerticalMovement {
    bool CheckCeiling(Vector3 location);
    void VelocityCheck();
}
