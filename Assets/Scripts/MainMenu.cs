using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // MainMenu
    public void NewGame()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("MenuLoadGame");
    }

    public void Keybinds()
    {
        SceneManager.LoadScene("MenuKeybinds");
    }


    public void Quit()
    {
        Application.Quit();
    }

    // SubScenes

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
