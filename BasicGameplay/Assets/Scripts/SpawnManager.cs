using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // ENCAPSULATION
    [SerializeField] private GameObject[] animalPrefabs;
    private float spawnRangeX = 18;
    private float spawnPosZ = 15;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void Start()
    {   
        // ABSTRACTION
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void SpawnRandomAnimal()
    {

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }
}
