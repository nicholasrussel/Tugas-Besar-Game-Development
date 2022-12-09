using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddManager : MonoBehaviour
{
    public static AddManager instance;
    public TextMeshProUGUI addText;
    float add = 0;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        addText.text = add.ToString() + " " + "points";
    }

    public float PowerUp()
    {
        add++;
        addText.text = add.ToString() + " " + "points";
        Debug.Log("Powerup saat ini = " + add);
        return add;
    }
}
