using System;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    public EventHandler OnInteractAction;
    private PlayerInputAction inputActions;

    private void Awake()
    {
        inputActions = new PlayerInputAction();
        inputActions.Player.Enable();
        inputActions.Player.Interact.performed += Interact_performed;

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
