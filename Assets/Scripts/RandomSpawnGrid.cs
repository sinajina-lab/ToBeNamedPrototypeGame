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

    Vector3 boxSize = new Vector3(0, 0, 0); // The size of the collision box
    [SerializeField] bool stop;

    //[SerializeField] LayerMask mask; // The LayerMask to filter objects with the name "mask"

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
        bool canSpawnHere = false;
        int safetyNet = 0;

        yield return new WaitForSeconds(startWait);

        while (!stop)
        {
            int spawnPointX = Random.Range(-2, 16);
            int spawnPointY = Random.Range(-1, 3);
            int spawnPointz = Random.Range(10, 20);

            Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY, spawnPointz);

            int i = Random.Range(0, 100);
            for (int j = 0; j < cube.Length; j++)
            {
                //Check if the random generated number i is between minProbabilityRange and maxProbabilityRange
                if (i >= cube[j].minProbabilityRange && i <= cube[j].maxProbabilityRange)
                {
                    Instantiate(cube[j].spawnObject, spawnPosition, Quaternion.identity);
                    break;
                }
            }

            canSpawnHere = PreventSpawnOverlap(spawnPosition);

            while (!canSpawnHere)
            {
                spawnPointX = Random.Range(-2, 16);
                spawnPointY = Random.Range(-1, 3);
                spawnPointz = Random.Range(10, 20);

                spawnPosition = new Vector3(spawnPointX, spawnPointY, spawnPointz);
                canSpawnHere = PreventSpawnOverlap(spawnPosition);

                safetyNet++;

                if (safetyNet > 50)
                {
                    Debug.Log("Too many attempts");
                    break;
                }
            }

            //Instantiate(cube[Random.Range(0, cube.Length)].spawnObject, spawnPosition, Quaternion.identity);

            yield return new WaitForSeconds(spawnWait);
        }
    }

    bool PreventSpawnOverlap(Vector3 spawnPosition)
    {
        Collider[] colliders = Physics.OverlapBox(spawnPosition, boxSize * 0.5f);
        //Collider[] colliders = Physics.OverlapBox(spawnPosition, boxSize * 0.5f, Quaternion.identity, mask);

        return colliders.Length == 0;
    }

    [System.Serializable]
    public class spawnProbability
    {
        public GameObject spawnObject;
        public int minProbabilityRange = 0;
        public int maxProbabilityRange = 0;
    }
}
