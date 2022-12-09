using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsHandler : MonoBehaviour
{

    public GameObject[] starPrefabs;
    public float pointsCollected = 0;
    private float pointsTotal = SpawnPesanan.instance.numberOfClone;
    public static StarsHandler instance;

    private void Awake()
    {
        instance = this;
    }

    private float countPercentStar(float pointsCountCollected, float pointsCountTotal)
    {
        float percent = (pointsCountCollected / pointsCountTotal) * 100.0f;
        Debug.Log("Points get = " + pointsCountCollected);
        Debug.Log("Points total = " + pointsCountTotal);
        return percent;
    }
    public void SpawnStar()
    {
        float scoreGet = ScoreManager.instance.AddPoint() + AddManager.instance.PowerUp() - SubstractManager.instance.PowerDown();
        float percentStar = countPercentStar(scoreGet, pointsTotal);
        Debug.Log("Hasil Persen" + " = " + percentStar);
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

    void Start()
    {
        SpawnStar();
    }

}