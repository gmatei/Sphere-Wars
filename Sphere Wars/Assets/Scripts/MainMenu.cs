using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Singleplayer()
        {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Singleplayer");
        }

    public void Multiplayer()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Multiplayer");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("HelpTutorial");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
