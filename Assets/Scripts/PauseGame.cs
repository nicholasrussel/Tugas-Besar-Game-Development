using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public bool isPaused;
    // Start is called before the first frame update
    public void ClickPauseButton()
    {
        Time.timeScale = 0f;
        isPaused = true;
    }

    // Update is called once per frame
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        isPaused = false;
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                ClickPauseButton();
            }
        }
    }
}
