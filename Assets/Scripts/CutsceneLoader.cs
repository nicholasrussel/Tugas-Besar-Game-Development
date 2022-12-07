using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CutsceneLoader : MonoBehaviour
{
    private int index;
    public int SceneIndex
    {
        get
        {
            return index;
        }

        set
        {

            index = value;
            
        }
    }
    public void LoadLevel() {
        Debug.Log("masuk");
        SceneManager.LoadSceneAsync(SceneIndex);
    }
}
