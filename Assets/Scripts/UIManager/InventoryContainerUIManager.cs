using UnityEngine;

public class InventoryContainerUIManager : MonoBehaviour
{
    public InventoryContainerBehaviour inventoryBehaviour;
    public GameObject InventoryPanel;
    public Transform InventorySlotPrefab;
    public int selectedInventoryStackIndex;

    void Awake(){
        selectedInventoryStackIndex = inventoryBehaviour.selectedStackIndex;
    }

    // Add the inventory stack UI
    public void AddInventoryStackUI(InventoryItemStackBehaviour stack) {
        inventoryBehaviour.AddStack(stack);
        UpdateInventoryUI();  // Make sure UI is updated when new stack is added
    }

    // Remove an inventory stack UI
    public void RemoveInventoryStackUI(InventoryItemStackBehaviour stack) {
        inventoryBehaviour.RemoveStack(stack);
        UpdateInventoryUI();  // Update UI when an item is removed
    }

    // Handle inventory stack selection
    public void SelectInventoryStackUI(int index) {
        selectedInventoryStackIndex = index;
        // Optionally, update the UI to highlight the selected stack, etc.
    }

    // Update the UI to reflect the current inventory state
    public void UpdateInventoryUI() {
        // Loop through the inventory stacks and update the UI accordingly
        foreach (var stack in inventoryBehaviour.stacks) {
            // For example, set icons, item names, and item amounts in the UI
            // (You'll need to create references to UI elements, like buttons or image/text fields, in your InventoryPanel)
            Debug.Log($"Updating UI for stack: {stack.stack.itemName} - Amount: {stack.itemNumber}");
            Instantiate(InventorySlotPrefab);
        }
    }
}
