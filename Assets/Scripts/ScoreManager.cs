using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText; // Use TMP_Text for TextMeshPro text
    public int[] scoreThresholds;
    private int currentScore = 0;
    private int currentThresholdIndex = 0;

    public StopWatch stopWatch;

    private void Start()
    {
        UpdateScoreUI();
        stopWatch = FindObjectOfType<StopWatch>();
    }

    public void IncreaseScore(int pointsEarned)
    {
        currentScore += pointsEarned;
        CheckThresholds();
        UpdateScoreUI();

        if (currentScore >= 30)
        {
            stopWatch.Begin(stopWatch.initialDuration);
        }
    }

    private void CheckThresholds()
    {
        for (int i = currentThresholdIndex; i < scoreThresholds.Length; i++)
        {
            if (currentScore >= scoreThresholds[i])
            {
                ActivateThreshold(i);
                currentThresholdIndex = i + 1;
            }
            else
            {
                break;
            }
        }
    }

    private void ActivateThreshold(int thresholdIndex)
    {
        Debug.Log("Threshold " + thresholdIndex + " reached!");
    }

    private void UpdateScoreUI()
    {
        scoreText.text = "Score: " + currentScore;
    }
}
