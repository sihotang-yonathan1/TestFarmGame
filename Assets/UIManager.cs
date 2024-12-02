using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject inventoryPanel;  // Reference to the inventory panel

    void Start()
    {
        // Make sure the inventory panel is hidden at the start
        if (inventoryPanel != null)
        {
            inventoryPanel.SetActive(false);
        }
    }

    // Call this method to toggle the inventory panel visibility
    public void ToggleInventoryPanel()
    {
        if (inventoryPanel != null)
        {
            inventoryPanel.SetActive(!inventoryPanel.activeSelf);
        }
    }
}
