using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] enemies;
    [SerializeField] Vector3 spawnValues;

    [SerializeField] float spawnWait;
    [SerializeField] float spawnMostWait;
    [SerializeField] float spawnLeastWait;
    [SerializeField] int startWait;

    [SerializeField] bool stop;

    int randEnemy;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }

    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)//true
        {
            randEnemy = Random.Range(0, 2);

            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));

            Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 1, 5), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }
}
