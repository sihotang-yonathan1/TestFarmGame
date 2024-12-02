using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SlotUI : MonoBehaviour
{
    public Button button;
    public Image itemIcon;
    public Text quantityText;

    private Slot slot;  // Reference to the Slot that this UI represents

    public void Initialize(Slot slot)
    {
        this.slot = slot;
        UpdateSlotUI();
    }

    public void UpdateSlotUI()
    {
        if (slot.item != null)
        {
            // Show the item icon and quantity
            itemIcon.sprite = slot.item.itemIcon;  // Assuming your ItemScriptableObject has an icon
            itemIcon.enabled = true;
            quantityText.text = slot.quantity.ToString();
            quantityText.enabled = true;
        }
        else
        {
            // Hide the icon and quantity if the slot is empty
            itemIcon.enabled = false;
            quantityText.enabled = false;
        }
    }
}
