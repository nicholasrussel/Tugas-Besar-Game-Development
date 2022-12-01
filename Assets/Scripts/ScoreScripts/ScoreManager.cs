using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    float score = 0;
    
    private void Awake(){
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + " " + "points";
    }

    public float AddPoint(){
        score++;
        scoreText.text = score.ToString() + " " + "points";
        Debug.Log("Skor saat ini = " + score);
        return score;
    }
}
