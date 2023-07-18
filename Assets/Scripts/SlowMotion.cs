using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SlowMotion : MonoBehaviour
{
    public GameObject SlowMotionCube = null;

    private void Start()
    {
        SlowMotionCube.SetActive(false);

        //ShowCube();
        StartCoroutine(WaitBeforeDisapear());
    }

    private void ShowCube()
    {
        SlowMotionCube.SetActive(true);

        //wait for seconds
    }

    IEnumerator WaitBeforeDisapear()
    {
        SlowMotionCube.SetActive(false);
        yield return new WaitForSeconds(5);
    }
}
