using UnityEngine;

public class ChestInteraction : MonoBehaviour
{
    public ChestAnimator animator;
    public GameInput gameInput;

    public bool isPlayerinRange = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (gameInput != null){
            gameInput.OnInteractAction += ToggleChest;
        }    
    }


    void ToggleChest(object sender, System.EventArgs e) 
    {
        if (isPlayerinRange)
        {
            Debug.Log("Interacted with chest");
            animator.ToggleChest();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPlayerinRange = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerinRange = false;
    }


}
