using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnGrid : MonoBehaviour
{
    [SerializeField] spawnProbability[] cube;

    [SerializeField] float spawnWait;
    [SerializeField] float spawnMostWait;
    [SerializeField] float spawnLeastWait;
    [SerializeField] float startWait;

    [SerializeField] bool stop;

    private void Start()
    {
        StartCoroutine(SpawnCube());
        
    }
    private void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }
    IEnumerator SpawnCube()
    {
        yield return new WaitForSeconds(startWait);

        while(!stop)
        {
            int spawnPointX = Random.Range(16, -2);
            int spawnPointY = Random.Range(0, 5);
            int spawnPointz = Random.Range(10, 20);

            Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY, spawnPointz);

            int i = Random.Range(0, 100);
            for(int j = 0; j < cube.Length; j++)
            {
                //Check if the random generated number i is between minProbabilityRange and maxProbabilityRange
                if (i >= cube[j].minProbabilityRange && i <= cube[j].maxProbabilityRange)
                {
                    Instantiate(cube[j].spawnObject, spawnPosition, Quaternion.identity);
                    break;
                }
            }

            //Instantiate(cube[Random.Range(0, cube.Length)], spawnPosition, Quaternion.identity);

            yield return new WaitForSeconds(spawnWait);
        }

    }

    [System.Serializable]
    public class spawnProbability
    {
        public GameObject spawnObject;
        public int minProbabilityRange = 0;
        public int maxProbabilityRange = 0;
    }
}
