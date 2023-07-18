using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSlowMotionBox : MonoBehaviour
{
    public GameObject gmObj;
    public static bool isHide = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isHide)
        {
            gmObj.SetActive(false);
        }
        else
        {
            gmObj.SetActive(true);
        }
    }
}
