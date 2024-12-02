using UnityEngine;
using UnityEngine.UI;

public class ButtonEventTrigger : MonoBehaviour
{
    public Button button;  // Reference to the UI Button

    // Declare an event that will be triggered when the button is clicked
    public event System.Action OnButtonClicked;

    void Start()
    {
        // Check if button is assigned in the Inspector
        if (button != null)
        {
            // Add the method to the button click event
            button.onClick.AddListener(OnButtonClickedHandler);
        }
        else
        {
            Debug.LogWarning("Button reference is not assigned in ButtonEventTrigger.");
        }
    }

    // The method that is called when the button is clicked
    private void OnButtonClickedHandler()
    {
        Debug.Log("Button clicked! Event triggered.");
        // Trigger the event
        OnButtonClicked?.Invoke();
    }
}
