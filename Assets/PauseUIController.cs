using System;
using UnityEngine;
using UnityEngine.UI;

public class PauseUIController : MonoBehaviour
{
    public UIManager uiManager;       // Reference to the UIManager
    public GameInput gameInput;

    public ButtonEventTrigger buttonEventTrigger;

    public Button resumeButton;

    void Start()
    {
        // Subscribe to GameInput pause action event
        if (gameInput != null)
        {
            gameInput.OnPauseAction += GameInput_OnPauseAction;
        }

        // Subscribe to button click event
        if (buttonEventTrigger != null)
        {
            buttonEventTrigger.OnButtonClicked += ButtonEventTrigger_OnButtonClicked;
        }
    }

    private void ButtonEventTrigger_OnButtonClicked()
    {
        TogglePauseScreen();
    }

    public void TogglePauseScreen()
    {
        Debug.Log("Button event triggered from ButtonEventTrigger.");

        Time.timeScale = Time.timeScale != 0 ? 0 : 1;
        
        if (uiManager != null)
        {
            uiManager.TogglePausePanel();
        }
        else
        {
            Debug.LogWarning("UIManager is not assigned in the PauseUIController.");
        }
    }

    private void GameInput_OnPauseAction(object sender, System.EventArgs e)
    {
        TogglePauseScreen();
    }

    private void OnDestroy()
    {
        // Unsubscribe to prevent memory leaks
        if (gameInput != null)
        {
            gameInput.OnPauseAction -= GameInput_OnPauseAction;
        }

        if (buttonEventTrigger != null)
        {
            buttonEventTrigger.OnButtonClicked -= ButtonEventTrigger_OnButtonClicked;
        }
    }
}
