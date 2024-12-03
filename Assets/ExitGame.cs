using UnityEngine;

public class ExitGame : MonoBehaviour
{
    // This function is called when the Exit button is clicked
    public void ExitApplication()
    {
        #if UNITY_EDITOR
            // If running in the Unity Editor, stop playing the scene
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            // If running as a built game, quit the application
            Application.Quit();
        #endif
    }
}
