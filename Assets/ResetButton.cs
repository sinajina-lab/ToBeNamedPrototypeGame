
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    public Transform ballTransform;
    private Vector3 initialPosition;

    void Start()
    {
        // Store the initial position of the ball when the game starts
        initialPosition = ballTransform.position;

        // Get the Button component from the GameObject
        Button button = GetComponent<Button>();

        // Add an onClick listener to the button and assign the ResetBall method
        button.onClick.AddListener(ResetBall);
    }

    // Method to reset the ball position
    public void ResetBall()
    {
        ballTransform.position = initialPosition;
    }
}