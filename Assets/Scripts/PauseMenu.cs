using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject panel;
    public GameObject levelPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseButton()
    {
        if(panel != null){
            panel.SetActive(true);
            //function time.timeScale = 0
        }
    }

    public void ReasumeButton()
    {
        panel.SetActive(false);
    }

    public void LevelButton()
    {
        panel.SetActive(false);
        levelPanel.SetActive(true);
    }

    public void BackLevelButton()
    {
        levelPanel.SetActive(false);
        panel.SetActive(true);
    }

    public void SettingButton()
    {
        panel.SetActive(false);
    }

    public void ExitButton(){
        Application.LoadLevel("MainMenu");
    }
}
