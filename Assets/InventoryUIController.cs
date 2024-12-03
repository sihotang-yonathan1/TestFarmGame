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
        
        if (uiManager == null)
        {
            Debug.LogError("UIManager is not assigned!");
        }
    }

    private void ToggleInventory(object sender, EventArgs e)
    {
        if (uiManager != null){
            uiManager?.ToggleInventoryPanel();
        } else {
            Debug.LogError("UIManager is not assigned!");
        }

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
