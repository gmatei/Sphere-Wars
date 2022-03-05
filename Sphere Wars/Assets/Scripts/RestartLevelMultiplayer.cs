using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelMultiplayer : MonoBehaviour
{

    [SerializeField]
    KeyCode keyRestart;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(keyRestart))
        {
            FindObjectOfType<PlayerLivesBlue>().OnMouseUp();
            FindObjectOfType<PlayerLivesYellow>().OnMouseUp();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
