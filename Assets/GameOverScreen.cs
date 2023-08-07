using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    public Text pointsText;
    //public TextMeshProUGUI pointsText;

    public void Setup(int score)
    {
        gameObject.SetActive(true);

        // Display the max score with " Coins" suffix
        pointsText.text = score.ToString() + " Coins";
    }
}
