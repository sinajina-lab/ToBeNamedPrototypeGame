using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManipulation : MonoBehaviour
{
    float timeDilation = 1f;

    public event EventHandler<OnTimeChangeArgs> OnTimeChange;

    public class OnTimeChangeArgs : EventArgs
    {
        public float newTimeDilation;
    }

    public void TimeChange(float newTimeDilation)
    {
        timeDilation = newTimeDilation;

        OnTimeChange.Invoke(this, new OnTimeChangeArgs { newTimeDilation = timeDilation });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
