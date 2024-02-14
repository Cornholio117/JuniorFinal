using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    [SerializeField] float spwanRangeX = 25f;
    [SerializeField] float spwanPosYMax = 11.5f;
    [SerializeField] float spwanPosYMin = -3.5f;
    [SerializeField] float startDely = 7.5f;
    [SerializeField] float startInterval;

    // Start is called before the first frame update
    void Start()
    {
        startInterval = Random.Range(1, 7);
        InvokeRepeating("SpawnRandomEnemy", startDely, startInterval);
    }

    void SpawnRandomEnemy()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spwanRangeX, Random.Range(spwanPosYMax, spwanPosYMin), 0);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
