using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject inventoryPanel;  // Reference to the inventory panel
    public GameObject pausePanel;

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
    }

    public void TogglePausePanel()
    {
        pausePanel?.SetActive(!pausePanel.activeSelf);
    }
}
