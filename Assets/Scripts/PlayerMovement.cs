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
        Debug.Log(inputVector);
        transform.position += moveVector * Time.deltaTime * movementSpeed;

        // Debug.Log(transform.position);
        // movementX = Input.GetAxisRaw("Horizontal");
        // movementY = Input.GetAxisRaw("Vertical");

        // Debug.Log(movementY);



        // if (movementX != 0)
        // {
        //    transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * movementSpeed;
        //};
        
        //if (movementY != 0)
        //{
        //   transform.position += new Vector3(0f, movementY, 0f) * Time.deltaTime * movementSpeed;
        //};

    }

    void AnimatePlayer(){
        if (inputVector.x < 0){
            //transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            spriteRenderer.flipX = true;
            animator.SetInteger(FACE_DIRECTION_NUMBER, 2);
        }

        else if (inputVector.x > 0) {
            spriteRenderer.flipX = false;
            animator.SetInteger(FACE_DIRECTION_NUMBER, 0);
        }



        // TODO: refactor
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
