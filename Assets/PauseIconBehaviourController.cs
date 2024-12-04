using UnityEngine;
using UnityEngine.UI;

public class PauseIconBehaviourController : MonoBehaviour
{
    public Button button;
    public UIManager uiManager;

    public void TogglePauseBehaviour(){
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
}
