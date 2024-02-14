using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spwanRangeX = 25f;
    private float spwanPosYMax = 11.5f;
    private float spwanPosYMin = -3.5f;
    private float startDely = 7.5f;
    private float startInterval;

    // Start is called before the first frame update
    void Start()
    {
        startInterval = Random.Range(1, 5);
        InvokeRepeating("SpawnRandomEnemy", startDely, startInterval);
    }

    void SpawnRandomEnemy()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spwanRangeX, Random.Range(spwanPosYMax, spwanPosYMin), 0);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
