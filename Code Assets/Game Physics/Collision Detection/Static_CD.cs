using UnityEngine;

public static class Static_CD {
    public static void PositionUpdateCD(Vector3 currentPosition, Vector3 nextPosition) {
        Vector3 midpoint = new Vector3((currentPosition.x + nextPosition.x) / 2f, (currentPosition.y + nextPosition.y) / 2f, (currentPosition.z + nextPosition.z) / 2f);
    }
}
