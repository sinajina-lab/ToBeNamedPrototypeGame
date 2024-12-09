
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private Button resetButton;

    private bool hasReset = true;  // Start with true so the initial reset can occur

    private void Start()
    {
        resetButton.onClick.AddListener(ResetButtonClicked);
    }

    private void ResetButtonClicked()
    {
        if (hasReset)
        {
            ResetPlayerPosition();
            hasReset = false;
        }
    }

    private void ResetPlayerPosition()
    {
        Player.transform.position = respawnPoint.transform.position;
    }

    // Add a method to allow resetting the hasReset flag, for example, when the game is restarted
    public void EnableReset()
    {
        hasReset = true;
    }
}