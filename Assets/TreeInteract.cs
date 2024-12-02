using System;
using UnityEngine;

public class TreeInteract : MonoBehaviour
{
    public GameObject tree;
    private bool isPlayerInRange;

    public float damage = 5f;

    public float health = 100f;
    public GameObject dropItem;
    public int dropItemNumber = 5;

    // Reference to the player's GameInput
    public GameInput gameInput;
    public Inventory playerInventory;

    void Start()
    {
        // Ensure GameInput is assigned and listen for interaction
        if (gameInput != null)
        {
            gameInput.OnInteractAction += OnInteractAction;
        }
    }

    private void OnInteractAction(object sender, System.EventArgs e)
    {
        // Only trigger if the player is in range
        if (isPlayerInRange)
        {
            Hit();
        }
    }

    private void Hit()
    {
        if (health > 0)
        {
            health -= damage;
            Debug.Log(health);
        }
        else
        {
            DropItems();
            Destroy(gameObject);
        }
    }

    private void DropItems()
    {
        if (dropItem != null && dropItemNumber > 0)
        {
            for (int i = 0; i < dropItemNumber; i++)
            {
                // Instantiate the dropItem at the tree's position
                Debug.Log("Instantiate Item Drop");
                GameObject newItem = Instantiate(dropItem);
                // Get the ItemPickup component and set the Inventory reference
                ItemPickup itemPickup = newItem.GetComponent<ItemPickup>();
                if (itemPickup != null)
                {
                    itemPickup.inventory = playerInventory;
                }
            }
        }
    }

    // Trigger detection to see if the player is near
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = false;
        }
    }

    void OnDestroy()
    {
        // Unsubscribe from event when destroyed to avoid memory leaks
        if (gameInput != null)
        {
            
            gameInput.OnInteractAction -= OnInteractAction;
        }
    }
}

