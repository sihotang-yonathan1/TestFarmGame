using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Dictionary<ItemScriptableObject, int> itemDictionary = new Dictionary<ItemScriptableObject, int>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void AddItem(ItemScriptableObject item)
    {
        if (itemDictionary.ContainsKey(item))
        {
            Debug.Log($"Object {item} is added");
            itemDictionary[item] += item.itemAmount;
        }
        else
        {
            Debug.Log($"No {item} in Dictionary, added {item} to Dictionary");
            itemDictionary.Add(item, item.itemAmount);
        }
    }

    public int GetItemAmount(ItemScriptableObject item)
    {
        if (!itemDictionary.ContainsKey(item))
        {
            return 0;
        }
        return itemDictionary[item];
    }
}
