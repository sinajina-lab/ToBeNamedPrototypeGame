using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class TextPopOnCollision : MonoBehaviour
{
    [SerializeField] GameObject FloatingTextPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FloatingTextPrefab)
        {
            ShowFloatingText();
        }
        
    }
    void ShowFloatingText()
    {
        //Instantiate(FloatingTextPrefab, transform.position, Quaternion.identity, transform);

    }
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(FloatingTextPrefab, transform.position, Quaternion.identity, transform);
    }
}
