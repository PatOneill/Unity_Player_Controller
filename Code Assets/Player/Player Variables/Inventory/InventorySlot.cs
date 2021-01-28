using UnityEngine;
public class InventorySlot {
    private GameObject _StoredItem;
    private AItem _ItemFunctionality;
    private int _CurrentStackAmount;
    private int _MaxStackAmount;
    private float _TotalWeight;
    private bool _Useable;

    public InventorySlot() {
        _StoredItem = null;
        _ItemFunctionality = null;
        _CurrentStackAmount = 0;
        _MaxStackAmount = 1;
        _TotalWeight = 0.0f;
        _Useable = false;
    }

    public bool Useable { get => _Useable; set => _Useable = value; }
    public GameObject StoredItem { get => _StoredItem; }
    public int CurrentStackAmount { get => _CurrentStackAmount; }
    public int MaxStackAmount { get => _MaxStackAmount; }
    public float TotalWeight { get => _TotalWeight; }
    public AItem ItemFunctionality { get => _ItemFunctionality; }

    public void StoreItem(GameObject item, AItem itemFunctionality) {
        _StoredItem = item;
        _ItemFunctionality = itemFunctionality;
        _MaxStackAmount = itemFunctionality.GetMaxStackAmount();
        _CurrentStackAmount = itemFunctionality.GetCurrentStackAmount();
        _TotalWeight = itemFunctionality.GetStackWeight();
        itemFunctionality.SetStackCount(0);
    }

    public void AddToExistingStack(AItem itemFunctionality) {
        int totalAmount = _CurrentStackAmount + itemFunctionality.GetCurrentStackAmount();
        if (_MaxStackAmount == _CurrentStackAmount) {
            return; //Slot already has the maximum amount of items it can hold
        } else if (totalAmount <= _MaxStackAmount) {
            _CurrentStackAmount = totalAmount;
            _TotalWeight += itemFunctionality.GetStackWeight(); //Calculate the new total weight for this stack of items
            itemFunctionality.SetStackCount(0); //The Item that has been picked up is complete use up so set its amount to zero
        } else {
            int diff = _MaxStackAmount - _CurrentStackAmount;
            itemFunctionality.SetStackCount(itemFunctionality.GetCurrentStackAmount() - diff);
            _TotalWeight += itemFunctionality.GetItemWeight() * diff; //Calculate the new total weight for this stack of items
            _CurrentStackAmount += diff;
        }
    }

    public bool CompareItemNames(string itemName) {
        if (_ItemFunctionality.GetItemName().Equals(itemName)) {
            return true;
        } else {
            return false;
        }
    }
}
