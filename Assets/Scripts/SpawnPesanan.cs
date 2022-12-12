using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPesanan : MonoBehaviour
{
    public GameObject[] pesananPrefabs;
    private float startDelay = 2;
    private float spawnInterval = 5f;
    public float numberOfClone = 0;

    public static SpawnPesanan instance;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        InvokeRepeating("SpawnRandomPesanan", startDelay, spawnInterval);
    }

    void SpawnRandomPesanan()
    {
        int pesananIndex = Random.Range(0, pesananPrefabs.Length);
        Instantiate(pesananPrefabs[pesananIndex], pesananPrefabs[pesananIndex].transform.position, Quaternion.identity);
        numberOfClone++;
    }
}