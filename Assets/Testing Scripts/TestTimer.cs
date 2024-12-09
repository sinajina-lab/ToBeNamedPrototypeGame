using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TestTimer : MonoBehaviour
{
    bool timerActive = false;

    [SerializeField] float currentTime;
    public int startMinutes;
    [SerializeField] Text currentTimeText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startMinutes * 60;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerActive == true) //Check if timer is active
        {
            currentTime = currentTime - Time.deltaTime;

            if(currentTime <= 0)
            {
                timerActive = false; // Stop the timer
                
                Start(); //Reset the time
                Debug.Log("Timer finished!");
            }
        }

        TimeSpan time = TimeSpan.FromSeconds(currentTime); //This variable stores the amount of time. Able to convert seconds to minutes, hours etc.
        currentTimeText.text = time.Minutes.ToString() + "" + time.Seconds.ToString();
    }

    public void StartTimer()
    {
        timerActive = true;
    }

    public void StopTimer()
    {
        timerActive = false;
    }
}
