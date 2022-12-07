using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    float currentTime;
    public float startingTime = 300;
    public TextMeshProUGUI textDisplay;
    [SerializeField] TextMeshProUGUI countdownText;
    public bool GameActive = true;
    public int levelToUnlock;
    int numberOfUnlockedLevels;

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

            Debug.Log("Game Selesai");
            //Nanti Ganti ke Win UI - Ed
            GameActive = false;
            Time.timeScale = 0;
            numberOfUnlockedLevels = PlayerPrefs.GetInt("levelsUnlocked");
            Debug.Log(numberOfUnlockedLevels);
        {
            if (numberOfUnlockedLevels <= levelToUnlock)
            {
                PlayerPrefs.SetInt("levelsUnlocked", numberOfUnlockedLevels + 1);
            }
        }
            Debug.Log(numberOfUnlockedLevels + "level 2 kebuka");
            SceneManager.LoadScene("MapWinMenu");
        }

    }
}
