using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondSpawnerScript : MonoBehaviour
{
    public GameObject[] diamondPrefabs;
    public int time = 600;
    // private float startDelay = 3;
    // private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating("SpawnRandomDiamond", startDelay, spawnInterval);
        SpawnRandomDiamond();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomDiamond()
    {
        // int diamondIndex = Random.Range(0, diamondPrefabs.Length);
        // Instantiate(diamondPrefabs[diamondIndex], diamondPrefabs[diamondIndex].transform.position, Quaternion.identity);
        
        while (time!=0)
        {
            if (time == 360)
            {
                Instantiate(diamondPrefabs[2], diamondPrefabs[2].transform.position, Quaternion.identity);
        
            }else if (time == 230)
            {
                Instantiate(diamondPrefabs[0], diamondPrefabs[0].transform.position, Quaternion.identity);
        
            }else if (time == 100)
            {
                Instantiate(diamondPrefabs[1], diamondPrefabs[1].transform.position, Quaternion.identity);
            }
            time--;
        }
        
    }
}
