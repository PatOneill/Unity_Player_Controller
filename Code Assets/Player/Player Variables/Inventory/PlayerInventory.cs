using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory {
    private int _CurrentSlotsInUse;
    private int _CurrentMaxInventorySlots;
    private int _MaxInventorySlots;
    private List<InventorySlot> _PlayerInventorySlots;
    
    public PlayerInventory() {
        _CurrentSlotsInUse = 0;
        _CurrentMaxInventorySlots = 10; //Player starts with 10 available slots
        _MaxInventorySlots = 30;
        _PlayerInventorySlots = new List<InventorySlot>(); //Player has a maximum of 30 inventory slots
        InitializeSlots();
    }

    private void InitializeSlots() {
        for(int count = 0; count < _MaxInventorySlots; ++count) {
            if(count+1 <= _CurrentMaxInventorySlots) {
                _PlayerInventorySlots.Add(new InventorySlot());
                _PlayerInventorySlots[count].Useable = true;
            } else {
                _PlayerInventorySlots.Add(new InventorySlot());
                _PlayerInventorySlots[count].Useable = false;
            }
        }
    }

    public bool HandlePick(GameObject item, AItem itemFunctionality) {
        int originalCount = itemFunctionality.GetCurrentStackAmount();
        AddItemToSlot(item, itemFunctionality);
        if(originalCount != itemFunctionality.GetCurrentStackAmount()) {
            return true; //An item was picked up
        } else {
            return false; //No item was picked up
        }
    }

    private void AddItemToSlot(GameObject item, AItem itemFunctionality) {
        foreach (InventorySlot slot in _PlayerInventorySlots) {
            if (slot.Useable) { //Check to see if the player has unlocked the ablity to use this inventory slot
                if (slot.StoredItem != null) { //This slot already has an item in it
                    if (slot.CompareItemNames(itemFunctionality.GetItemName())) { //Check to see if the share the same name
                        slot.AddToExistingStack(itemFunctionality);
                    }
                } else {
                    slot.StoreItem(item, itemFunctionality); //Store the item's info into the inventory slot
                    _CurrentSlotsInUse += 1;
                    break;
                }
            }
            if(itemFunctionality.GetCurrentStackAmount() == 0) {
                break;
            }
        }
    }

}
