using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPesanan : MonoBehaviour
{
    public GameObject[] pesananPrefabs;
    private float startDelay = 2;
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
        int pesananIndex = Random.Range(0, pesananPrefabs.Length);
        Instantiate(pesananPrefabs[pesananIndex], pesananPrefabs[pesananIndex].transform.position, Quaternion.identity);
    }
}
