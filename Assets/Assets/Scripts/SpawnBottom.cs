using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBottom : MonoBehaviour
{
    public GameObject[] spawn;
    private int zRange = -9;
    private int startDelay = 1;
    private int spawnInterval = 1;


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

        Vector3 spawnPos = new Vector3(Random.Range(-16, 17), 4, zRange);

        int spawnItem = Random.Range(0, spawn.Length);

        Instantiate(spawn[spawnItem], spawnPos, spawn[spawnItem].transform.rotation);

    }
}
