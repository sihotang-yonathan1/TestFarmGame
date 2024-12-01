using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D rigidBody;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    public GameInput gameInput;

    private Vector2 inputVector;
    public Vector2 lastMotionMovement;

    // Initial value
    public float movementSpeed = 5f;
    public float movementX;
    public float movementY;

    // Constant 
    private string IS_WALKING = "isWalk";


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
       
        if (inputVector.x < 0f)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }


        animator.SetFloat("horizontal", inputVector.x);

        animator.SetFloat("vertical", inputVector.y);

        // if moving
        bool isWalking = inputVector.x != 0 || inputVector.y != 0;
        if (isWalking)
        {
            animator.SetBool(IS_WALKING, true);
        }
        else {
            animator.SetBool(IS_WALKING, false);
        }
 
        
        if (isWalking)
        {
            lastMotionMovement = new Vector2(inputVector.x, inputVector.y).normalized;
            animator.SetFloat("lastHorizontal", inputVector.x);
            animator.SetFloat("lastVertical", inputVector.y);
        }

    }
}
