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
    private void Start()
    {
        currentPoints = points;
    }
    private void Update()
    {
        if (currentPoints >= -1  )
        {
            currentPoints = 0;
            //const bool die = true;
            //GameController.gameOver = die;
            OnPlayerDeath?.Invoke();
        }
    }
}
