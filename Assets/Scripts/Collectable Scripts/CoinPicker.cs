using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinPicker : MonoBehaviour
{
    private int coin = 0;

    [SerializeField] private TextMeshProUGUI foodText;

    //[SerializeField] private AudioSource AntSoundEffect;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coins"))
        {
            //AntSoundEffect.Play();

            Destroy(collision.gameObject);
            coin++;
            foodText.text = "" + coin;
        }
    }
}
