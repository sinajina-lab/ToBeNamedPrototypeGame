using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SlowMotion : MonoBehaviour
{
    public GameObject SlowMotionCube = null;

    // Duration for which the SlowMotionCube stays active
    public float activeDuration = 5f;

    private void Start()
    {
        SlowMotionCube.SetActive(false);
    }

    private void ShowSlowMotionCube()
    {
        SlowMotionCube.SetActive(true);
        StartCoroutine(DeactivateAfterDuration());
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enable")
        {
            ShowSlowMotionCube();
        }
    }

    IEnumerator DeactivateAfterDuration()
    {
        SlowMotionCube.SetActive(true);

        // Wait for the specified duration
        yield return new WaitForSeconds(activeDuration);

        // Deactivate the SlowMotionCube
        SlowMotionCube.SetActive(false);
    }
}
