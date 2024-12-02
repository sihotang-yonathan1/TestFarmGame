using System;
using UnityEngine;

public class InventoryUIController : MonoBehaviour
{
    public UIManager uiManager;       // Reference to the UIManager
    public GameInput gameInput;       // Reference to the GameInput

    void Start()
    {
        if (gameInput != null)
        {
            gameInput.OnToggleInventory += ToggleInventory;
        }
    }

    private void ToggleInventory(object sender, EventArgs e)
    {
        uiManager.ToggleInventoryPanel();
    }


    void OnDestroy()
    {
        // Unsubscribe from the event to prevent memory leaks
        if (gameInput != null)
        {
            gameInput.OnToggleInventory -= ToggleInventory;
        }
    }
}
