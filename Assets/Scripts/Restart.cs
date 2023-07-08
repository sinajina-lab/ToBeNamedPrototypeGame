using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Vector3 startPosition;

    public void Reset()
    {
        //startPosition = transform.position;
    }
    public void RestartGame()
    {
        //SceneManager.LoadScene("Prototype");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Start is called before the first frame update
    void Start()
    {
        print("This scene has been loaded");

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
