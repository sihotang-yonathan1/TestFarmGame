using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using static UnityEngine.InputManagerEntry;
using System.Xml.Linq;
using TMPro;
using UnityEditor.PackageManager.UI;

public class UIManager : MonoBehaviour
{
    public GameObject inventoryPanel;  // Reference to the inventory panel
    public GameObject pausePanel;
    public GameObject inventorySlotPrefab; // Inventory Slot prefab
    public Transform inventorySlotParent;  // Parent object to hold the inventory slots

    public Inventory inventory; // Reference to player's inventory

    void Start()
    {
        // Make sure the panel is hidden at the start
        inventoryPanel?.SetActive(false);
        pausePanel?.SetActive(false);
    }

    // Call this method to toggle the inventory panel visibility
    public void ToggleInventoryPanel()
    {
        inventoryPanel?.SetActive(!inventoryPanel.activeSelf);

        if (inventoryPanel.activeSelf)
        {
            UpdateInventoryUI();  // Update the UI when the inventory panel is opened
        }
    }

    public void TogglePausePanel()
    {
        pausePanel?.SetActive(!pausePanel.activeSelf);
    }

    // Update Inventory UI (called when the panel is toggled)
    public void UpdateInventoryUI()
    {
        // Clear any existing slots
        foreach (Transform child in inventorySlotParent)
        {
            Destroy(child.gameObject);
        }

        // Create a slot for each item in the inventory
        foreach (var itemPair in inventory.itemDictionary)
        {
            CreateInventorySlot(itemPair.Key, itemPair.Value);  // Create slots for each item
        }
    }

    // Create an inventory slot for an item
    private void CreateInventorySlot(ItemScriptableObject item, int amount)
    {
        // Instantiate the slot prefab
        GameObject slot = Instantiate(inventorySlotPrefab, inventorySlotParent);

        // Access the InventorySlot script attached to the slot prefab
        InventorySlot slotScript = slot.GetComponent<InventorySlot>();
        Debug.Log($"Slot Script {slotScript}");
        // Set the item and amount using the InventorySlot script
        slotScript.SetItem(item);

    }

}
