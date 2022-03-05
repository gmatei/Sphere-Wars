using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenuMultiplayer : MonoBehaviour
{

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            {
            if (Time.timeScale < 0.1f)
                
                Resume();
                else
                Pause();
                 
            }

    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
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
