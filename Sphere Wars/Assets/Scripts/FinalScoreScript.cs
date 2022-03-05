using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;

    void Start()
    {
        score = GetComponent<Text>();
    }
    
    void Update()
    {
    score.text = "Final Score: " + scoreValue;  
    }

    public void OnMouseUp()
    {
        scoreValue = 0;
    }
}
