using UnityEngine;
using System.Collections;


public class CropManager : MonoBehaviour
{
    public Crop cropType;  // The type of crop (e.g., wheat, corn)
    public float currentGrowthTime = 0f;  // Tracks the current growth time
    public bool isPlanted = true;
    public bool isHarvested = false;
    public SpriteRenderer cropRenderer;  // To display crop sprites
    public float growthSpeed = 1f;  // Speed at which crops grow (time multiplier)

    private void Start()
    {
        // Ensure that the cropRenderer is assigned
        if (cropRenderer == null)
            cropRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (isPlanted && !isHarvested)
        {
            GrowCrop();
        }
    }

    private void GrowCrop()
    {
        // Increase growth time based on speed
        currentGrowthTime += Time.deltaTime * growthSpeed;

        // Change crop's appearance based on growth stage
        float growthProgress = currentGrowthTime / cropType.growthTime;
        int growthStage = Mathf.FloorToInt(growthProgress * (cropType.growthStages.Length));

        // If we reached the final stage, show the full-grown crop
        if (growthStage < cropType.growthStages.Length)
        {
            cropRenderer.sprite = cropType.growthStages[growthStage];
        }

        // Check if the crop is ready to harvest
        if (growthProgress >= 1f)
        {
            isHarvested = true;  // Crop is ready for harvesting
        }
    }

    public void PlantCrop()
    {
        if (!isPlanted)
        {
            isPlanted = true;
            currentGrowthTime = 0f;  // Reset growth time
            isHarvested = false;
        }
    }

    public void HarvestCrop()
    {
        if (isHarvested)
        {
            // Logic for harvesting crop (e.g., give player items)
            Debug.Log($"Harvested {cropType.cropName}, got {cropType.yieldAmount} items!");

            // Reset crop state
            isPlanted = false;
            currentGrowthTime = 0f;
            isHarvested = false;
            cropRenderer.sprite = null;  // Remove crop image (or set to initial stage)
        }
    }
}



/*
public class CropManager : MonoBehaviour
{
    public Crop cropType;  // The type of crop (e.g., wheat, corn)
    public float currentGrowthTime = 0f;  // Tracks the current growth time
    public bool isPlanted = false;
    public bool isHarvested = false;
    public SpriteRenderer cropRenderer;  // To display crop sprites
    public float growthSpeed = 1f;  // Speed at which crops grow (time multiplier)
    public GameObject plantingSpot; // To track planting position

    private void Start()
    {
        // Ensure that the cropRenderer is assigned
        if (cropRenderer == null)
            cropRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (isPlanted && !isHarvested)
        {
            GrowCrop();
        }
    }

    private void GrowCrop()
    {
        // Increase growth time based on speed
        currentGrowthTime += Time.deltaTime * growthSpeed;

        // Change crop's appearance based on growth stage
        float growthProgress = currentGrowthTime / cropType.growthTime;
        int growthStage = Mathf.FloorToInt(growthProgress * (cropType.growthStages.Length));

        // If we reached the final stage, show the full-grown crop
        if (growthStage < cropType.growthStages.Length)
        {
            cropRenderer.sprite = cropType.growthStages[growthStage];
        }

        // Check if the crop is ready to harvest
        if (growthProgress >= 1f)
        {
            isHarvested = true;  // Crop is ready for harvesting
        }
    }

    public void PlantCrop(Crop crop)
    {
        if (!isPlanted)
        {
            cropType = crop;
            isPlanted = true;
            currentGrowthTime = 0f;  // Reset growth time
            isHarvested = false;
        }
    }

    public void HarvestCrop()
    {
        if (isHarvested)
        {
            // Logic for harvesting crop (e.g., give player items)
            Debug.Log($"Harvested {cropType.cropName}, got {cropType.yieldAmount} items!");

            // Reset crop state
            isPlanted = false;
            currentGrowthTime = 0f;
            isHarvested = false;
            cropRenderer.sprite = null;  // Remove crop image (or set to initial stage)
        }
    }
}

*/