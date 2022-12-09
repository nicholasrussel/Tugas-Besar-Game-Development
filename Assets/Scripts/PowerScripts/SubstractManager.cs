using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SubstractManager : MonoBehaviour
{
    public static SubstractManager instance;
    public TextMeshProUGUI substractText;
    float substract = 0;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        substractText.text = substract.ToString() + " " + "points";
    }

    public float PowerDown()
    {
        substract++;
        substractText.text = substract.ToString() + " " + "points";
        Debug.Log("PowerDown saat ini = " + substract);
        return substract;
    }
}
