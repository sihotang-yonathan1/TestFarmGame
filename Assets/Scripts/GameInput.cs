using System;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    public EventHandler OnInteractAction;
    public event EventHandler OnToggleInventory;
    public event EventHandler OnPauseAction;
    private PlayerInputAction inputActions;

    private void Awake()
    {
        inputActions = new PlayerInputAction();
        inputActions.Player.Enable();
        inputActions.Player.Interact.performed += Interact_performed;
        inputActions.Player.InventoryToggle.performed += InventoryToggle_performed;
        inputActions.Player.Pause.performed += Pause_performed;

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
