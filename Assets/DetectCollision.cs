using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enable")
        {
            ShowSlowMotionBox.isHide = true;
        }
        else if(collision.gameObject.tag == "Disable")
        {
            ShowSlowMotionBox.isHide = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
