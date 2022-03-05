using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverPanelUI;

    public void Pause()
    {
        GameOverPanelUI.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void LoadMenu()
    {
        FindObjectOfType<FinalScoreScript>().OnMouseUp();
        SceneManager.LoadScene("MainMenu");
    }

    public void Replay()
    {
        Time.timeScale = 1f;
        FindObjectOfType<FinalScoreScript>().OnMouseUp();
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }
}