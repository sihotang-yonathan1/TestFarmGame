using UnityEngine;

public class ChestAnimator : MonoBehaviour
{
    public Animator animator;
    public bool isOpen = false;

    public string IS_OPEN_PARAM_KEY = "isOpen";
    public string ANIMATION_NAME = "ChestOpen";

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Start()
    {
        animator.speed = 0;
    }

    // Update is called once per frame

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

    private void OpenChest()
    {
        animator.StopPlayback();
        animator.speed = 1f;
        // play animation from beginning
        animator.Play(ANIMATION_NAME, 0, 0f);
        
    }

    private void CloseChest()
    {
        animator.StopPlayback();
        // play backwards
        animator.speed = -1;
        animator.Play(ANIMATION_NAME, 0, -1);
    }
}
