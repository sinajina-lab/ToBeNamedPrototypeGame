using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeductPoints : MonoBehaviour
{
    public static event Action OnPlayerDeath;

    private int currentPoints = 0;
    private int points = 0;
    public int deduct = -5;

    [SerializeField] private TextMeshProUGUI foodText;

    //[SerializeField] private AudioSource AntSoundEffect;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Deduct"))
        {
            //AntSoundEffect.Play();

            Destroy(collision.gameObject);
            deduct--;
            //foodText.text = "" + deduct;
            UpdateScore();
        }
    }
    private void Start()
    {
        currentPoints = points;
        UpdateScore();
    }

    public void UpdateScore()
    {
        currentPoints = deduct;
        foodText.text = currentPoints.ToString();

        if (currentPoints <= 0)
        {
            GameController.PlayerDeath();
        }
    }
    public void MinusPoints()
    {
        deduct--;
        UpdateScore();
    }
}
