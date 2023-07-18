using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBox : MonoBehaviour
{
    public float TimeValue = 1f;

        private void OnTriggerEnter(Collider other)
    {
        TimeManipulation tm;
        if(other.TryGetComponent<TimeManipulation>(out tm))
        {
            tm.TimeChange(TimeValue);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        TimeManipulation tm;
        if (other.TryGetComponent<TimeManipulation>(out tm))
        {
            tm.TimeChange(1);
        }
    }
}
