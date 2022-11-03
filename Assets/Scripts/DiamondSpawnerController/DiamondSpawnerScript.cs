using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondSpawnerScript : MonoBehaviour
{
    public GameObject[] diamondPrefabs;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomDiamond", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomDiamond()
    {
        int diamondIndex = Random.Range(0, diamondPrefabs.Length);
        Instantiate(diamondPrefabs[diamondIndex], diamondPrefabs[diamondIndex].transform.position, Quaternion.identity);
    }
}
