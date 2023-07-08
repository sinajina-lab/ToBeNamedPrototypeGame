using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;

    public ThrowObject resetBall;
    public Vector3 startPosition;

    private void Awake()
    {
        startPosition = transform.position;
    }
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Prototype");
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }
    public void ResetBallButton()
    {
        transform.position = startPosition;
        //resetBall.ResetBall();
        //FindObjectOfType<BallThrower>().ResetBall();
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Prototype");
        Debug.Log("Restart Game");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Main Menu");
    }
    public void quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    public void OnPaused()
    {
        Time.timeScale = 0f;
    }

    public void OnUnPaused()
    {
        Time.timeScale = 1f;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
        
    }
}
