using UnityEngine;

public class ChestUIManager : MonoBehaviour
{
    public GameObject chest;
    public GameObject inventoryPanel;
    public ChestAnimator chestAnimator;
    
    public bool isOpen = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        chestAnimator.isOpen = this.isOpen;
    }

    // TODO: open on Interact
    public void OpenChestUI(){
        inventoryPanel.SetActive(isOpen);
        chestAnimator.OpenChest();
        
        // Stop the animation immidiately after the 1st animation play
        chestAnimator.animator.speed = 0;
        chestAnimator.animator.SetBool(chestAnimator.IS_OPEN_PARAM_KEY, !chestAnimator.isOpen);
    }

    // Close after interact
    public void CloseChestUI(){
        inventoryPanel.SetActive(!isOpen);
        chestAnimator.CloseChest();

        // Stop the animation immidiately after the 1st animation play
        chestAnimator.animator.speed = 0;
    }
}
