using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public float currentTime;
    public float startingTime = 300;
    public static float score;
    public TextMeshProUGUI textDisplay;
    [SerializeField] TextMeshProUGUI countdownText;
    public bool GameActive = true;
    public int levelToUnlock;
    int numberOfUnlockedLevels;
    public GameObject game;
    public GameObject game2;
    public GameObject highScoreMenu;
    public GameObject leaderBoardMenu;
    public TextMeshProUGUI leaderBoard;
    public TextMeshProUGUI highScore;

    void Start()
    {
        currentTime = startingTime;
    }
    void SetText()
    {
        int Minute = Mathf.FloorToInt(currentTime / 60);
        int Second = Mathf.FloorToInt(currentTime % 60);
        countdownText.text = Minute.ToString("00") + ":" + Second.ToString("00");

    }

    // Update is called once per frame
    void Update()
    {
        if (GameActive)
        {
            SetText();
            currentTime -= 1 * Time.deltaTime;

            if (currentTime <= 0)
            {
                currentTime = 0;
            }

        }

        if (GameActive && currentTime == 0)
        {
            game.SetActive(false);
            game2.SetActive(false);
            Debug.Log("Game Selesai");
            //Nanti Ganti ke Win UI - Ed
            GameActive = false;
            Time.timeScale = 0;
            numberOfUnlockedLevels = PlayerPrefs.GetInt("levelsUnlocked");
            Debug.Log(numberOfUnlockedLevels);
            //Save High Score
            string highScoreLevel = "HighScore" + levelToUnlock.ToString();
            score = AddUang.uang;
            Debug.Log("Score:"+score);
            if(score>PlayerPrefs.GetFloat(highScoreLevel)){
                PlayerPrefs.SetFloat(highScoreLevel, score);
            }
            Debug.Log("New High Score stage "+highScoreLevel+": "+PlayerPrefs.GetFloat(highScoreLevel));
            leaderBoardMenu.SetActive(true);
            LeaderBoard(PlayerPrefs.GetFloat(highScoreLevel));
        
            if (numberOfUnlockedLevels <= levelToUnlock)
            {
                PlayerPrefs.SetInt("levelsUnlocked", numberOfUnlockedLevels + 1);
            }
        }

    }

    void LeaderBoard(float score)
    {
        leaderBoardMenu.SetActive(true);
        float hans = 20;
        float russel = 24;
        float edwan = 26;
        float wilson = 30;
        float player = score;
        string playerScore = player.ToString();

        if(player>wilson){
            leaderBoard.text = "Player   $" + playerScore + "\n Wilson   $30 \n Edwan    $26 \n Russel   $24 \n Hans     $20";
        }
        else if(player>edwan){
            leaderBoard.text = "\n Wilson   $30 \n Player   $" + playerScore + "\n Edwan    $26 \n Russel   $24 \n Hans     $20";
        }
        else if(player>russel){
            leaderBoard.text = "\n Wilson   $30 \n Edwan    $26 \n Player   $" + playerScore + "\n Russel   $24 \n Hans     $20";
        }
        else if(player>hans){
            leaderBoard.text = "\n Wilson   $30 \n Edwan    $26 \n Russel   $24 \n Player   $" + playerScore + "\n Hans     $20";
        }
        else{
            leaderBoard.text = "\n Wilson   $30 \n Edwan    $26 \n Russel   $24 \n Hans     $20 \n Player   $" + playerScore;
        }
    }
}
