using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Die")
        {
            GameController.gameOver = true;
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
