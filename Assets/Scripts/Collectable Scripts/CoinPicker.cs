using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinPicker : MonoBehaviour
{
    //public static event Action OnPlayerDeath;

    private GameController gameController;

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

            /*if (coin > GameController.maxPoints) // Check if the current score is higher than the max score
            {
                GameController.maxPoints = coin; // Update the max score if needed
            }*/
        }
    }
    private void Start()
    {
        gameController = FindObjectOfType<GameController>();

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

        /*if (coin > maxPoints) // Check if the current score is higher than the max score
        {
            maxPoints = coin; // Update the max score if needed
        }*/

        UpdateScore();
    }
}
