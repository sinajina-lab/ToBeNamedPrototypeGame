using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] items;
    [SerializeField] List<GameObject> list = new List<GameObject>();
    
    [SerializeField] bool randomSpawn = false, autoSpawn = false;

    [SerializeField] GameObject item = null;
    [SerializeField] float min = -5, max = 5;
    [SerializeField] int itemCount = 0;

    [SerializeField] Transform startPos;//spawnpoint position

    [SerializeField] int numberOfRows;
    [SerializeField] int objectsPerRow;
    [SerializeField] float spacing;

    // Start is called before the first frame update
    void Start()
    {
        System.Array.Clear(items, 0, items.Length);
        //items = (GameObject[])Resources.LoadAll("collectable");


        for (int row = 0; row < numberOfRows; row++)
        {
            for (int col = 0; col < objectsPerRow; col++)
            {
                Vector3 startinfPos = new Vector3(startPos.position.x + col * spacing, startPos.position.y - row * spacing, startPos.position.z);

            }
        }

        foreach (GameObject item in items)
        {
            list.Add(item);
        }

    }

    // Update is called once per frame
    void Update()
    {
        randomSpawn = !randomSpawn;

        GetItem();

        Vector3 spawnPos = transform.position + new Vector3(Random.Range(min, max), Random.Range(min, max), Random.Range(min, max));

        Instantiate(item, spawnPos, transform.rotation);
    }
    void GetItem()
    {
        if(randomSpawn)
        {
            item = list[Random.Range(0, list.Count)];
        }
        else
        {
            if(itemCount > list.Count -1)
            {
                itemCount = 0;
            }
            item = list[itemCount];
            itemCount++;
        }
    }
}
