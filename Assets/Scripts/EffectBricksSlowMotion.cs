using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectBricksSlowMotion : MonoBehaviour
{
    TimeManipulation timeManipulation;
    float timeDilation = 1f;

    //Rigidbody rb;
    //float moveSpeed = 20f;

    private void Awake()
    {
        timeManipulation = GetComponent<TimeManipulation>();
        //rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        timeManipulation.OnTimeChange += TimeChange;
        //rb.AddForce(transform.right * moveSpeed * timeDilation, ForceMode.Impulse);
    }

    public void TimeChange(object sender, TimeManipulation.OnTimeChangeArgs e)
    {
        timeDilation = e.newTimeDilation;

        //var vel = rb.velocity;
        //rb.velocity = Vector3.zero;
        //rb.AddForce(vel.normalized * moveSpeed * timeDilation, ForceMode.Impulse);
    }
}
