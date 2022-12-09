using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddUang : MonoBehaviour
{
    public TextMeshProUGUI uangText;
    public static AddUang instance;
    float uang = 0;
    private void Awake(){
        instance = this;
    }

    void Start(){
        uangText.text = uang.ToString();
    }

    public void JumlahUang(){
        float angka = Random.Range(1,10);
        uang+=angka;
        uangText.text = uang.ToString();
        Debug.Log("Nambah Cuyu");
    }
}
