using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTime : MonoBehaviour
{
    //1f = Normal Time
    public float timeScaleOnTrigger = 0.5f; // The desired time scale when the object is triggered
    public float timeScaleDuration = 2.0f; // The duration for which the time scale will be affected

    private float originalTimeScale = 1f; // Stores the original time scale before triggering

    private void Start()
    {
        originalTimeScale = Time.timeScale; // Store the original time scale at the beginning
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(ChangeTimeScale()); // Start the coroutine to change time scale
        }
    }

    private System.Collections.IEnumerator ChangeTimeScale()
    {
        Time.timeScale = timeScaleOnTrigger; // Set the desired time scale

        // Wait for the specified duration
        yield return new WaitForSecondsRealtime(timeScaleDuration);

        Time.timeScale = originalTimeScale; // Restore the original time scale after the duration
    }
}