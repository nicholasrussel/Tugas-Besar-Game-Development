using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{
    public GameObject correctForm;

    public GameObject wrongForm;
    public GameObject posisiPrefabsForm;
    private bool moving;
    private bool finish;
    private Vector3 resetPosition;
    private float startPosX;
    private float startPosY;

    void Start()
    {
        resetPosition = this.transform.localPosition;
    }

    void Update()
    {
        if (finish == false)
        {
            if (moving)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);

            }
        }

    }

    private void OnMouseDown()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            moving = true;
        }
    }

    private void OnMouseUp()
    {
        moving = false;
        var koordinatMouse = this.transform.position;
        int sumbuX = (int)koordinatMouse.x;
        var koordinatGambarBenar = correctForm.transform.position;
        var koordinatGambarSalah = wrongForm.transform.position;
        var koordinatGambarPrefab = posisiPrefabsForm.transform.position;
        int sumbuXGambarBenar = (int)koordinatGambarBenar.x;
        int sumbuXGambarSalah = (int)koordinatGambarSalah.x;


        if (Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 5f &&
           Mathf.Abs(this.transform.localPosition.y - correctForm.transform.localPosition.y) <= 5f)
        {
            Debug.Log(this.gameObject.name);
            Debug.Log(sumbuX);
            Debug.Log(sumbuXGambarBenar);
            Debug.Log(sumbuXGambarSalah);
            Debug.Log("if ke 1");
            this.transform.position = new Vector3(correctForm.transform.position.x, correctForm.transform.position.y, correctForm.transform.position.z);
            if (sumbuX == sumbuXGambarBenar)
            {
                Debug.Log("gambar benar");
                finish = true;
                float scoreTambah = ScoreManager.instance.AddPoint();
            }
            else if (sumbuX == sumbuXGambarSalah)
            {
                Debug.Log("gambar salah");
                finish = true;
            }

        }
        else if (Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 100f &&
           Mathf.Abs(this.transform.localPosition.y - correctForm.transform.localPosition.y) <= 100f)
        {
            Debug.Log(sumbuX);
            Debug.Log(sumbuXGambarBenar);
            Debug.Log(sumbuXGambarSalah);
            Debug.Log("if ke 2");
            this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
        }

        StarsHandler.instance.SpawnStar();
    }
}