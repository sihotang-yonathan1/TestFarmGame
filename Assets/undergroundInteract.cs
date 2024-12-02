using UnityEngine;

public class UndergroundInteract : MonoBehaviour { 
    public GameObject itemWhenActive;
    public GameObject itemWhenInactive;
    public bool currentState;

    private bool isPlayerInRange = false;

    // Reference to the player's GameInput
    public GameInput gameInput;

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
            SwitchState();
        }
    }

    void SwitchState()
    {
        currentState = !currentState;

        if (currentState)
        {
            Debug.Log("Under Ground Door Open");
            itemWhenActive.SetActive(true);
            itemWhenInactive.SetActive(false);
        }
        else
        {
            Debug.Log("Under Ground Door Closed");
            itemWhenActive.SetActive(false);
            itemWhenInactive.SetActive(true);
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

