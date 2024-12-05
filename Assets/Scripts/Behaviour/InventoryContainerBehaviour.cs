using System.Collections.Generic;
using UnityEngine;

public class InventoryContainerBehaviour : MonoBehaviour
{
    public List<InventoryItemStackBehaviour> stacks = new List<InventoryItemStackBehaviour>();
    public int selectedStackIndex = 0;
    public int maxStack = 30;

    public void AddStack(InventoryItemStackBehaviour stack){
        if (stack.stackId == null){
            stack.stackId = stacks.Count;  
        }
        if (stacks.Count < maxStack){
            Debug.Log($"Added {stack} to stacks");
            stacks.Add(stack);
        }
        else {
            Debug.LogError("Over the max stack count");
        }
    }

    public void RemoveStack(InventoryItemStackBehaviour item){
        stacks.Remove(item);
    }

    public InventoryItemStackBehaviour GetSelectedStack(int stackIndex){
        return stacks[stackIndex];
    }
}
