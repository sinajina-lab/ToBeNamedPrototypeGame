using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TestStopwatch : MonoBehaviour
{
    bool stopwatchActive = false;

    [SerializeField] float currentTime;
    [SerializeField] Text currentTimeText;

    //Score
    int score;
    [SerializeField] Text scoreText;
    [SerializeField] float multiplier = 5;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (stopwatchActive == true) //Check if timer is active
        {
            currentTime = currentTime + Time.deltaTime;
        }

        score = Mathf.RoundToInt(currentTime * multiplier);
        scoreText.text = score.ToString();

        TimeSpan time = TimeSpan.FromSeconds(currentTime); //This variable stores the amount of time. Able to convert seconds to minutes, hours etc.
        currentTimeText.text = time.ToString(@"fff");
        //currentTimeText.text = time.ToString(@"mm\:ss\:fff");
    }

    public void StartStopwatch()
    {
        stopwatchActive = true;
    }

    public void StopStopwatch()
    {
        stopwatchActive = false;
    }
}
