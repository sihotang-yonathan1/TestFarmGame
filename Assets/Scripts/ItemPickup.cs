using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public ItemScriptableObject item;
    public Inventory inventory;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collider is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            PickupItem();
        }
    }

    private void PickupItem()
    {
        // Add the item to the player's inventory
        if (inventory != null && item != null)
        {
            Debug.Log($"{item} picked up");
            inventory.AddItem(item);
        }

        // Destroy the item after pickup
        Destroy(gameObject);
    }
}
