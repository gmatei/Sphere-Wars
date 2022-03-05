using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverYellow : MonoBehaviour
{

    public GameObject GameOverPanelYellowUI;

    public void Pause()
    {
        GameOverPanelYellowUI.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void LoadMenu()
    {
        FindObjectOfType<PlayerLivesBlue>().OnMouseUp();
        FindObjectOfType<PlayerLivesYellow>().OnMouseUp();
        SceneManager.LoadScene("MainMenu");
    }

    public void Replay()
    {
        Time.timeScale = 1f;
        FindObjectOfType<PlayerLivesBlue>().OnMouseUp();
        FindObjectOfType<PlayerLivesYellow>().OnMouseUp();
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }
}