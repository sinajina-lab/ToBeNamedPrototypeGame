using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeController : MonoBehaviour
{
    float timeDilation = 1f;
    public event EventHandler<OnTimeChangeArgs> OnTimeChange;

    public class OnTimeChangeArgs : EventArgs
    {
        public float newTimeDilation;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TimeChange(float newTimeDilation)
    {
        timeDilation = newTimeDilation;

        OnTimeChange.Invoke(this, new OnTimeChangeArgs { newTimeDilation = timeDilation});
    }
}
