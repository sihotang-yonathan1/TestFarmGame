using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventorySlot : MonoBehaviour
{
    public Image iconImage;       // Reference to the Image for the item icon
    public TextMeshProUGUI amountText;  // Reference to the TextMeshPro for the item amount

    // Method to set item icon and amount in the slot
    public void SetItem(ItemScriptableObject item)
    {
        iconImage.sprite = item.itemIcon;  // Set the item icon
        amountText.text = item.itemAmount.ToString();  // Set the item amount as text
    }
}
