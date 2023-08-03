using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    TimeController timeController;
    float timeDilation = 1f;

    float bulletSpeed = 3f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        timeController = GetComponent<TimeController>();

        rb = GetComponent<Rigidbody>();
    }

    private void OnTimeChange(object sender, TimeController.OnTimeChangeArgs e)
    {
        timeDilation = e.newTimeDilation;

        var vel = rb.velocity;
        rb.velocity = Vector3.zero;
        rb.AddForce(vel.normalized * bulletSpeed * timeDilation, ForceMode.Impulse);
    }
}
