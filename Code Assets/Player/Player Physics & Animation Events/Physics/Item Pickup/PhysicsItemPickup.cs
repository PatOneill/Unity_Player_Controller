using UnityEngine;

public class PhysicsItemPickup {
    private PlayerInventory _PlayerInventory;
    private PlayerUI _PlayerUiDisplay;
    private readonly float _DetectionRange;
    private readonly string _PickUpItemTag;
    private readonly string _ItemHolderTag;
    private RaycastHit _SelectedItem;

    public PlayerInventory PlayerInventory { set => _PlayerInventory = value; }
    public PlayerUI PlayerUiDisplay {  set => _PlayerUiDisplay = value; }

    public PhysicsItemPickup() {
        _DetectionRange = 5f;
        _PickUpItemTag = "Item";
        _ItemHolderTag = "ItemHolder";
        _SelectedItem = new RaycastHit();
    }

    public bool ItemInteraction() {
        Ray cameraCenterPoint = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));
        if (Physics.Raycast(cameraCenterPoint, out _SelectedItem, maxDistance: _DetectionRange)) {
            string itemTag = _SelectedItem.transform.tag;
            if(itemTag.Equals(_PickUpItemTag)) {
                InteractableItem itemFunctions = _SelectedItem.transform.gameObject.GetComponent<InteractableItem>();
                bool playAnimation = _PlayerInventory.HandlePick(_SelectedItem.transform.gameObject, itemFunctions.GetItemFunctionallity()); //See if the player added the item(s) to their inventory (true: requires state change | false: no state change required)
                itemFunctions.ShouldBeDestroyed();
                return playAnimation;
            } else {
                return false; //The player hit an object with their raycast, but it was not an interactable item, so no state change is required
            }
        } else {
            return false; //The player didn't hit anything with their raycast, so no state change is requires 
        }
    }
}
