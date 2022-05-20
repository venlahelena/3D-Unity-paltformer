using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerLogic : MonoBehaviour
{
    public int countDownStartValue = 120;
    public Text timerUI;

    // Start is called before the first frame update
    void Start()
    {
        CountDownTimer();
    }

    void CountDownTimer()
    {
        if(countDownStartValue > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            timerUI.text = spanTime.Minutes + ":" + spanTime.Seconds;
            countDownStartValue--;
            Invoke("CountDownTimer", 1.0f);
        }
        else
        {
            GameManager.isGameOver = true;
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
