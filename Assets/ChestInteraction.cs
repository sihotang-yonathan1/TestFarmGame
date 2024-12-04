using UnityEngine;

public class ChestInteraction : MonoBehaviour
{
    public GameInput gameInput;
    public bool isChestOpen = false;
    public ChestUIManager chestUiManager;

    public bool isPlayerinRange = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (gameInput != null){
            gameInput.OnInteractAction += ToggleChest;
        }    
        chestUiManager.isOpen = isChestOpen;
    }


    void ToggleChest(object sender, System.EventArgs e) 
    {
        if (isPlayerinRange)
        {
            Debug.Log("Interacted with chest");
            if (isChestOpen){
                // Close when the chest is open
                chestUiManager.CloseChestUI();
            }
            else {
                chestUiManager.OpenChestUI();
            }
            isChestOpen = !isChestOpen;
            
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
