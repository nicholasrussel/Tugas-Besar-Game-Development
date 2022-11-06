using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpSettingButton : MonoBehaviour
{
    public GameObject panel;
    public GameObject panel2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SettingButton()
    {
        if(panel != null){
            panel.SetActive(true);
        }
    }

    public void BackButton()
    {
        panel.SetActive(false);
        panel2.SetActive(true);
    }
}
