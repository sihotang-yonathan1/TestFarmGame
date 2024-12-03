using UnityEngine;
using UnityEngine.SceneManagement;




public class NewGameScript : MonoBehaviour
{
    const int MAIN_GAME_SCREEN_INDEX = 0;
    const int NEW_GAME_SCREEN_INDEX = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Method to load the main game scene
    public void StartGame()
    {
        // Load the main game scene (replace "MainGameScene" with your actual scene name)
        SceneManager.LoadScene(MAIN_GAME_SCREEN_INDEX);
    }

    // Optionally, add a method to go back to the StartGameScreen
    public void LoadStartGameScreen()
    {
        SceneManager.LoadScene(NEW_GAME_SCREEN_INDEX);
    }
}
