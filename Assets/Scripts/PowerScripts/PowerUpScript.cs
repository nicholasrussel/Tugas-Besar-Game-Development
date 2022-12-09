using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    public float resultAdd = 0;
    public static PowerUpScript instance;

    void Awake()
    {
        instance = this;
    }
    void OnMouseDown()
    {
        Destroy(gameObject);
        resultAdd = AddManager.instance.PowerUp();
    }
}
