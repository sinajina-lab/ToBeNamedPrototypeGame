using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 moveVector;

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1); //Load next scene
    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
}
