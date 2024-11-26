using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D rigidBody;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    public GameInput gameInput;

    private Vector2 inputVector;

    // Initial value
    public float movementSpeed = 5f;
    public float movementX;
    public float movementY;

    // Constant 
    private string FACE_DIRECTION_NUMBER = "FaceDirection";
    // The direction are
    // East: 0
    // South: 1
    // West: 2
    // North: 3


    void Start()
    {
        gameInput.OnInteractAction += GameInput_OnInteractAction;
    }

    private void GameInput_OnInteractAction(object sender, System.EventArgs e) {
        Debug.Log("Hello World! from E Key");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovementController();
        AnimatePlayer();
    }

    void PlayerMovementController(){
        inputVector = gameInput.GetMovementVectorNormalized();
        Vector3 moveVector = new Vector3(inputVector.x, inputVector.y, 0f);
        // Debug.Log(inputVector);
        transform.position += moveVector * Time.deltaTime * movementSpeed;

    }

    void AnimatePlayer(){
        if (inputVector.x < 0){
            spriteRenderer.flipX = true;
            animator.SetInteger(FACE_DIRECTION_NUMBER, 2);
        }

        else if (inputVector.x > 0) {
            spriteRenderer.flipX = false;
            animator.SetInteger(FACE_DIRECTION_NUMBER, 0);
        }

        if (inputVector.y< 0)
        {
            animator.SetInteger(FACE_DIRECTION_NUMBER, 1);
        }
        else if (inputVector.y > 0)
        {
            animator.SetInteger(FACE_DIRECTION_NUMBER, 3);
        }

    }
}
