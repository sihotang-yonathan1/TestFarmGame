using System.Collections.Generic;
using UnityEngine;

public class InventoryItemStackBehaviour : MonoBehaviour
{
    public int? stackId;
    public ItemScriptableObject stack;
    public int itemNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Awake(){
        itemNumber = stack.itemAmount;
    }

    public void AddItem(int amount = 1){
        itemNumber = itemNumber + amount;
    }

    public void RemoveItem(int amount = 1){
        itemNumber = itemNumber - amount;
    }

    public void SetItem(ItemScriptableObject item, int itemAmount){
        
    }
}
