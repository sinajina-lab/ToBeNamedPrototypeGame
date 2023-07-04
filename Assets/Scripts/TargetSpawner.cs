using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField] float range;
    [SerializeField] float delay;
    [SerializeField] GameObject[] objectsToSpawn;

    Transform spawnParent;

    // Start is called before the first frame update
    void Start()
    {
        spawnParent = GameObject.Find("Spawned Objects").transform;

        StartCoroutine(WaitToSpawn());
    }
    IEnumerator WaitToSpawn()
    {
        yield return new WaitForSeconds(delay);
        Spawn();
    }
    void Spawn()
    {
        Instantiate(objectsToSpawn[Random.Range(0, objectsToSpawn.Length)], new Vector3(transform.position.x + Random.Range(-range, range), transform.position.y, transform.position.z),transform.rotation, spawnParent);
        StartCoroutine(WaitToSpawn());
    }
}
