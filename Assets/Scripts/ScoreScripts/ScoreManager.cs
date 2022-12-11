using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreTextKurang;
    float score = 0;
    float scoreTambah = 0;
    float scoreKurang = 0;
    private void Awake(){
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        score = scoreTambah - scoreKurang;
        scoreText.text = score.ToString();
        scoreTextKurang.text = score.ToString();
    }

    public float AddPoint(){
        scoreTambah++;
        scoreText.text = scoreTambah.ToString();
        Debug.Log("Point tambah sekarang = " +scoreTambah);
        return scoreTambah;
    }

    public float SubtractPoint(){
        scoreKurang++;
        scoreTextKurang.text = scoreKurang.ToString();
        Debug.Log("Point kurang sekarang = " +scoreKurang);
        return scoreKurang;
    }
}