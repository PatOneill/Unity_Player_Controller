using UnityEngine;

public class InteractableItem : MonoBehaviour {
    private AItem _ItemFunctionality;

    private void Awake() {
        _ItemFunctionality = new InstantHealPotion();
    }

    public AItem GetItemFunctionallity() {
        return _ItemFunctionality;
    }

    public void ShouldBeDestroyed() {
        if(_ItemFunctionality.GetCurrentStackAmount() == 0) {
            Destroy(this.transform.gameObject);
        }
    }
}
