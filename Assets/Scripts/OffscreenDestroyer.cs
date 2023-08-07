using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffscreenDestroyer : MonoBehaviour
{
   /* private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Destroy"))
        {
            Destroy(other.gameObject);
        }
    } */

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 8f);
    }
}
