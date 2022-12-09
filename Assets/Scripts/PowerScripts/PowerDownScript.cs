using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerDownScript : MonoBehaviour
{
    public float resultSubstract = 0;
    public static PowerDownScript instance;

    void Awake()
    {
        instance = this;
    }
    void OnMouseDown()
    {
        Destroy(gameObject);
        resultSubstract = SubstractManager.instance.PowerDown();
    }
}
