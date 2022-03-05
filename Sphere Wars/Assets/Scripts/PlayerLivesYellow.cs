using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLivesYellow : MonoBehaviour
{

    public static int scoreValue = 5;
    Text score;

    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "YELLOW: " + scoreValue;

    }

    public void OnMouseUp()
    {
        scoreValue = 5;
    }
}