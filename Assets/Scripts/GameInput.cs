using System;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    public EventHandler OnInteractAction;
    public event EventHandler OnToggleInventory;
    public event EventHandler OnPauseAction;
    private PlayerInputAction inputActions;

    public event EventHandler OnPlant;
    public event EventHandler OnHarvest;

    private void Awake()
    {
        inputActions = new PlayerInputAction();
        inputActions.Player.Enable();
        
        // Common Interaction
        inputActions.Player.Interact.performed += Interact_performed;
        
        // UI Related
        inputActions.Player.InventoryToggle.performed += InventoryToggle_performed;
        inputActions.Player.Pause.performed += Pause_performed;

        // plant interaction
        inputActions.Player.Harvest.performed += Harvest_performed;
        inputActions.Player.Plant.performed += Plant_performed;

    }

    private void Plant_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        Debug.Log("Plant Perfomed by using keybinding");
        OnPlant?.Invoke(this, EventArgs.Empty);
    }

    private void Harvest_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        Debug.Log("Harvest Perfomed by using keybinding");
        OnHarvest?.Invoke(this, EventArgs.Empty);
    }



    private void Pause_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnPauseAction?.Invoke(this, EventArgs.Empty);
    }

    private void InventoryToggle_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnToggleInventory?.Invoke(this, EventArgs.Empty);
    }

    private void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnInteractAction?.Invoke(this, EventArgs.Empty);
    }

    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 result = inputActions.Player.Move.ReadValue<Vector2>();

        result = result.normalized;

        return result;
    }
}
