using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelManager : MonoBehaviour
{
    public Button [] levelButtons;

    void start (){
        int levelAt = PlayerPrefs.GetInt("levelAt", 1);

        for(int i = 0; i< levelButtons.Length; i++){

            if(i + 2 > levelAt){
                levelButtons[i].interactable = false;
            }
        }
    }

    
}
