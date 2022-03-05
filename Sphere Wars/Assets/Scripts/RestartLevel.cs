using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    [SerializeField]
    KeyCode keyRestart;

    void FixedUpdate()
    {
        if (Input.GetKey(keyRestart))
            {
            FinalScoreScript.scoreValue = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
    }
}
