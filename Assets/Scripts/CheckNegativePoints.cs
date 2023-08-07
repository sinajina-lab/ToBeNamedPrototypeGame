using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckNegativePoints : MonoBehaviour
{
    //public static event Action OnPlayerDeath;

    private int currentPoints = 0;
    private int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentPoints = points;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPoints < 0 )
        {
            currentPoints = 0;
            const bool die = true;
            GameController.gameOver = die;
            //OnPlayerDeath?.Invoke();
        }
    }
}
