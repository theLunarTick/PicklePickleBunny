using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] picklePrefabs;
    public float spawnRangeX = 2.3f;
    public float spawnRangeY = 4f;
    public float startDelay = 2f;
    public float spawnInternal = 1.5f;


    void Start()
    {
        InvokeRepeating("SpawnRandomPickle", startDelay, spawnInternal);
    }

    void Update()
    {

    }

    void SpawnRandomPickle()
    {
        int pickleIndex = Random.Range(0, picklePrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY), 0);

        Instantiate(picklePrefabs[pickleIndex], spawnPos, picklePrefabs[pickleIndex].transform.rotation);
    }
}
