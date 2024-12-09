using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StopWatch : MonoBehaviour
{
    [SerializeField] private TMP_Text targetScoreText;
    [SerializeField] private TextMeshProUGUI targetScore;
    [SerializeField] private Text targetScorePanel;

    public ScoreManager scoreManager;

    [SerializeField] Image uiFill;
    [SerializeField] TMP_Text uiText; // Use TMP_Text for TextMeshPro text

    public int initialDuration = 60;
    private int remainingDuration;

    public int scoreThreshold = 10;
    public int timeBonus = 5;

    private int currentScore = 0;
    private bool isCountdownActive = false;

    void Start()
    {
        isCountdownActive = false;
        uiText.text = "00 : 00";
        remainingDuration = initialDuration;
        StartCoroutine(UpdateTimer());

        // Display the target score and panel before each game session
        DisplayTargetScore();
        StartCoroutine(StartGame());
    }

    IEnumerator StartGame()
    {
        // Wait for a few seconds before starting the game
        yield return new WaitForSeconds(3f);
        // Hide the target score panel and start the timer
        HideTargetScore();
        Begin(initialDuration);
    }

    void Update()
    {
        // When the score reaches the threshold, add time bonus and start/restart the timer
        if (currentScore >= scoreThreshold && !isCountdownActive)
        {
            remainingDuration += timeBonus;
            currentScore = 0; // Reset the score
            Begin(initialDuration); // Start/restart the timer
        }

        // You can add more game logic here as needed
    }

    public void Begin(int seconds)
    {
        remainingDuration = seconds;
        uiText.enabled = true;
        StartCoroutine(UpdateTimer());
    }

    IEnumerator UpdateTimer()
    {
        while (remainingDuration > 0)
        {
            uiText.text = $"{remainingDuration / 60:00} : {remainingDuration % 60:00}";
            uiFill.fillAmount = Mathf.InverseLerp(0, initialDuration, remainingDuration);
            remainingDuration--;
            yield return new WaitForSeconds(1f);
        }

        Debug.Log("The timer has run out!");

        // Transition to the game over scene (you can change the scene name)
        SceneManager.LoadScene("GameOver");
    }

    // Method to increase the player's score
    public void IncreaseScore(int amount)
    {
        currentScore += amount;
    }

    // Method to display the target score
    void DisplayTargetScore()
    {
        targetScoreText.text = "Target Score: " + targetScore;
        targetScorePanel.enabled = true;
    }

    // Method to hide the target score panel
    void HideTargetScore()
    {
        targetScorePanel.enabled = false;
    }

    // Function to award a time bonus when a power-up is collected
    public void CollectPowerUp()
    {
        // Check if the player has collected the power-up (add your specific conditions here)
        bool powerUpCollected = true; // Replace with your condition check

        if (powerUpCollected)
        {
            // Award the time bonus
            remainingDuration += timeBonus;
        }
    }
}
