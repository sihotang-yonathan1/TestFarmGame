using UnityEngine;

public class CropInteraction : MonoBehaviour
{
    public CropManager cropManager;

    // Check for player interaction (e.g., pressing a button)
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))  // P for plant
        {
            Debug.Log("Tryong to plant");
            cropManager.PlantCrop();
        }

        if (Input.GetKeyDown(KeyCode.H))  // H for harvest
        {
            Debug.Log("Trying to Harvest");
            cropManager.HarvestCrop();
        }
    }
}
