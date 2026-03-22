using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OpenSettings()
    {
        Debug.Log("Settings clicked");
    }

    public void LoadGame()
    {
        Debug.Log("Load Game clicked");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}