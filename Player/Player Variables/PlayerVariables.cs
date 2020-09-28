using UnityEngine;

public class PlayerVariables : MonoBehaviour
{
    [SerializeField] private float _BaseMaxHealth;
    [SerializeField] private float _CurrentMaxHealth;
    [SerializeField] private float _CurrentHealth;

    [SerializeField] private float _BaseMaxWalkSpeed;
    [SerializeField] private float _CurrentMaxWalkSpeed;

    [SerializeField] private float _BaseMaxSprintSpeed;
    [SerializeField] private float _CurrentMaxSprintSpeed;

    [SerializeField] private Vector3 _GroundCollisionCheckOverlayArea;

    [SerializeField] private Vector3 _Standing_CeilingCollisionCheckOverlayArea;
    [SerializeField] private Vector3 _Standing_HorizontalCollisionCheckOverlayArea;

    [SerializeField] private Vector3 _Crouching_CeilingCollisionCheckOverlayArea;
    [SerializeField] private Vector3 _Crouching_HorizontalCollisionCheckOverlayArea;

    private void Awake() {
        
    }
}
