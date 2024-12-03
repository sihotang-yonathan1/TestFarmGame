using System;
using UnityEngine;

/*
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
*/

public class CropInteraction : MonoBehaviour
{
    public CropManager cropManager;
    public GameInput gameInput; // Reference to GameInput class

    private void OnEnable()
    {
        if (gameInput != null)
        {
            gameInput.OnPlant += OnPlantAction;
            gameInput.OnHarvest += OnHarvestAction;
        }
    }

    private void OnPlantAction(object sender, EventArgs e)
    {
        // Logic to plant a crop
        if (!cropManager.isPlanted && cropManager.cropType != null)
        {
            cropManager.PlantCrop(cropManager.cropType);  // Pass the crop type here
            Debug.Log("Planting crop...");
        }
    }

    private void OnDisable()
    {
        if (gameInput != null)
        {
            gameInput.OnPlant -= OnPlantAction;
            gameInput.OnHarvest -= OnHarvestAction;
        }
    }

    private void OnHarvestAction(object sender, EventArgs e)
    {
        // Logic to harvest a crop
        if (cropManager.isHarvested)
        {
            cropManager.HarvestCrop();
            Debug.Log("Harvesting crop...");
        }
    }
}

