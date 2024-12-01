using UnityEngine;

public class ToolCharacterController : MonoBehaviour
{
    public PlayerMovement characterController;
    public Rigidbody2D rigidbody2D;

    private void Awake()
    {
        characterController = GetComponent<PlayerMovement>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
}
