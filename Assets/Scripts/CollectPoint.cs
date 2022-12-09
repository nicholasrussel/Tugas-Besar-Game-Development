using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPoint : MonoBehaviour
{
    public GameObject coinPrefab;
    

    void OnMouseDown(){
        Destroy(coinPrefab);
        AddUang.instance.JumlahUang();
    }
}
