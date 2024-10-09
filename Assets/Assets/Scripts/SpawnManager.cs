using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] spawn;
    private int xRange = 10;
    private int zRange = 1;
    private int startDelay = 10;
    private float spawnInterval = 15.5f;


    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnItems", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {

     
    }

    void SpawnItems()
    {

        // Spawns items

        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), 4, zRange);

        int spawnItem = Random.Range(0, spawn.Length);

        Instantiate(spawn[spawnItem], spawnPos, spawn[spawnItem].transform.rotation);

    }

}
