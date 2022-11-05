using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPesanan : MonoBehaviour
{
    public GameObject[] pesananPrefabs;
    private float startDelay = 5;
    private float spawnInterval = 10f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomPesanan", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomPesanan()
    {
        int diamondIndex = Random.Range(0, pesananPrefabs.Length);
        Instantiate(pesananPrefabs[diamondIndex], pesananPrefabs[diamondIndex].transform.position, Quaternion.identity);
    }
}
