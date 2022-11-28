using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsHandler : MonoBehaviour
{

    public GameObject[] starPrefabs;
    private float coinsCollected = 4;
    private float coinsTotal = 4;
    // private float startDelay = 3;
    // private float spawnInterval = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating("SpawnRandomStar", startDelay, spawnInterval);
        SpawnStar();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnStar()
    {
        // int diamondIndex = Random.Range(0, diamondPrefabs.Length);
        // Instantiate(diamondPrefabs[diamondIndex], diamondPrefabs[diamondIndex].transform.position, Quaternion.identity);

        float percentStar = countPercentStar(coinsCollected, coinsTotal);

        if (percentStar <= 25.0f)
        {
            Instantiate(starPrefabs[0], starPrefabs[0].transform.position, Quaternion.identity);
        }
        else if (percentStar <= 50.0f)
        {
            Instantiate(starPrefabs[0], starPrefabs[0].transform.position, Quaternion.identity);
            Instantiate(starPrefabs[1], starPrefabs[1].transform.position, Quaternion.identity);
        }
        else if (percentStar <= 75.0f)
        {
            Instantiate(starPrefabs[0], starPrefabs[0].transform.position, Quaternion.identity);
            Instantiate(starPrefabs[1], starPrefabs[1].transform.position, Quaternion.identity);
            Instantiate(starPrefabs[2], starPrefabs[2].transform.position, Quaternion.identity);
        }
        else
        {
            Instantiate(starPrefabs[0], starPrefabs[0].transform.position, Quaternion.identity);
            Instantiate(starPrefabs[1], starPrefabs[1].transform.position, Quaternion.identity);
            Instantiate(starPrefabs[2], starPrefabs[2].transform.position, Quaternion.identity);
            Instantiate(starPrefabs[3], starPrefabs[3].transform.position, Quaternion.identity);
        }
    }

    private float countPercentStar(float coinsCollected, float coinsTotal)
    {
        float percent = (coinsCollected / coinsTotal) * 100.0f;
        return percent;
    }
}
