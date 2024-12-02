using UnityEngine;

[CreateAssetMenu(fileName = "New Crop", menuName = "Crop System/Crop")]
public class Crop : ScriptableObject
{
    public string cropName;
    public float growthTime;  // Time in seconds to fully grow
    public Sprite[] growthStages;  // Visual representations for each stage
    public int yieldAmount;  // Amount of crops given when harvested
}
