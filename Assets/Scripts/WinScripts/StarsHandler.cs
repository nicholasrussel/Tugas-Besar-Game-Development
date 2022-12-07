using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StarsHandler : MonoBehaviour
{

 public GameObject[] starPrefabs;
    public float pointsCollected = 0;
    
    public static StarsHandler instance;
     private void Awake(){
        instance = this;
    }

    private float countPercentStar(float pointsCountCollected, float pointsCountTotal)
    {
        float percent = (pointsCountCollected / pointsCountTotal) * 100.0f;
        return percent;
    }
    public void SpawnStar()
    {
        
        float scoreGet = ScoreManager.instance.AddPoint();
        float scoreLess = ScoreManager.instance.SubtractPoint();
        float totalPesanan = scoreGet + scoreLess;
        float percentStar = countPercentStar(scoreGet, totalPesanan);
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
