using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automove : MonoBehaviour
{
    //GameManager GameManager;
    SceneLoader sceneLoader;

    // Start is called before the first frame update
    void Start()
    {
        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
        //GameManager = gameController.GetComponent<GameManager>();
        sceneLoader = gameController.GetComponent<SceneLoader>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(GameManager.moveVector * GameManager.moveSpeed * Time.deltaTime);
        transform.Translate(sceneLoader.moveVector * sceneLoader.moveSpeed * Time.deltaTime);
    }
}
