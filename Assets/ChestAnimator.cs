using UnityEngine;

public class ChestAnimator : MonoBehaviour
{
    public Animator animator;
    public bool isOpen = false;

    public string IS_OPEN_PARAM_KEY = "isOpen";
    public string ANIMATION_NAME = "ChestOpen";

    private void Start()
    {
        // Stop animation when not interacted
        animator.speed = 0;
    }

    public void ToggleChest()
    {
        if (isOpen) {
            CloseChest();
        } else {
            OpenChest();
        }
        animator.speed = 0;
        animator.SetBool(IS_OPEN_PARAM_KEY, isOpen);
        isOpen = !isOpen;
    }

    public void OpenChest()
    {
        Debug.Log("[Animation] Chest Animated to Open");
        animator.StopPlayback();
        animator.speed = 1f;
        // play animation from beginning
        animator.Play(ANIMATION_NAME, 0, 0f);
        
    }

    public void CloseChest()
    {
        Debug.Log("[Animation] Chest Animated to Close");
        animator.StopPlayback();
        // play backwards
        animator.speed = -1;
        animator.Play(ANIMATION_NAME, 0, -1);
    }
}
