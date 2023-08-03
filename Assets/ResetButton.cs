
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    public GameObject ballPrefab;
    private Vector3 initialPosition;

    void Start()
    {
        // Store the initial position of the ball when the game starts
        initialPosition = GameObject.FindGameObjectWithTag("Player").transform.position;

        // Get the Button component from the GameObject
        Button button = GetComponent<Button>();

        // Assign the ResetBall method to the onClick event of the button
        button.onClick.AddListener(ResetBall);
    }

    // Method to respawn the ball at its initial position
    private void ResetBall()
    {
        // Destroy the existing ball (if any)
        GameObject existingBall = GameObject.FindGameObjectWithTag("Player");
        if (existingBall != null)
        {
            Destroy(existingBall);
        }

        // Instantiate a new ball at the initial position
        Instantiate(ballPrefab, initialPosition, Quaternion.identity);
    }
}