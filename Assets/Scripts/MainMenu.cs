using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NewGame()
    {
        //SceneManager.LoadScene();
    }

    public void LoadGame()
    {
        //SceneManager.LoadScene();
    }

    public void Keybinds()
    {
        SceneManager.LoadScene("MenuKeybinds");
    }


    public void Quit()
    {
        Application.Quit();
    }
}
