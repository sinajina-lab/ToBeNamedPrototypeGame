using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinPicker : MonoBehaviour
{
    //public static event Action OnPlayerDeath;

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
            UpdateScore();
        }
    }
    private void Start()
    {
        UpdateScore();
    }

    private void UpdateScore()
    {
        foodText.text = coin.ToString();
    }

    // Add points when called externally (from Explosive script)
    public void AddPoints()
    {
        coin++;
        UpdateScore();
    }
}
