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
            //ResetTimer();
        }
    }
}
