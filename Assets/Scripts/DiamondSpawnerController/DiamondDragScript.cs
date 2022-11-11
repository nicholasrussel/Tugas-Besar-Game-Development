using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondDragScript : MonoBehaviour
{
    public Vector2 mousePos;
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }
}
