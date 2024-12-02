using System.Collections.Generic;
using UnityEngine;

public class ChestInventory : MonoBehaviour
{
    public int maxSlots = 32;
    public List<Slot> slots = new List<Slot>();

    void Start()
    {
        // Initialize chest slots
        for (int i = 0; i < maxSlots; i++)
        {
            slots.Add(new Slot());
        }
    }

    // Same methods for adding/removing items from the chest
    public bool AddItem(ItemScriptableObject item, int quantity = 1)
    {
        foreach (var slot in slots)
        {
            if (slot.item == item)
            {
                slot.quantity += quantity;
                return true;
            }
            if (slot.item == null)
            {
                slot.item = item;
                slot.quantity = quantity;
                return true;
            }
        }
        return false;
    }

    public bool RemoveItem(ItemScriptableObject item, int quantity = 1)
    {
        foreach (var slot in slots)
        {
            if (slot.item == item)
            {
                slot.quantity -= quantity;
                if (slot.quantity <= 0)
                {
                    slot.item = null;
                }
                return true;
            }
        }
        return false;
    }
}
