using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeductPoints : MonoBehaviour
{
    private int deduct = -5;

    [SerializeField] private TextMeshProUGUI foodText;

    //[SerializeField] private AudioSource AntSoundEffect;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Deduct"))
        {
            //AntSoundEffect.Play();

            Destroy(collision.gameObject);
            deduct--;
            foodText.text = "" + deduct;
        }
    }
}
