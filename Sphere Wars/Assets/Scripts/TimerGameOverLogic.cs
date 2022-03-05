using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerGameOverLogic : MonoBehaviour
{
    public int countDownStartValue;
    public Text timerUI;
    public GameObject GameOverPanelUI;

    void Start()
    {
        CountDownTimer();
    }

    void CountDownTimer()
        {
        if (countDownStartValue > 0)
            {
            timerUI.text = "Time: " + countDownStartValue;
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
            }
            else
            {
            FindObjectOfType<GameOver>().Pause();
            timerUI.text = "Game over!";
            }     
        }
}
