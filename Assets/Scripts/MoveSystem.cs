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

        // if (Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 5f &&
        //    Mathf.Abs(this.transform.localPosition.y - correctForm.transform.localPosition.y) <= 5f)
        // {
        //     Debug.Log(this.gameObject.name);
        //     Debug.Log(correctForm.gameObject.name);
        //     Debug.Log("if ke 1");
        //     this.transform.position = new Vector3(correctForm.transform.position.x, correctForm.transform.position.y, correctForm.transform.position.z);
        //     if(this.gameObject.name == correctForm.gameObject.name){
        //         Debug.Log("if if ke 1");
        //         finish = true;
        //     } else {
        //         Debug.Log("if if ke 2");
        //         finish = true;
        //     }

        // }else if(Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 100f &&
        //    Mathf.Abs(this.transform.localPosition.y - correctForm.transform.localPosition.y) <= 100f){
        //     Debug.Log("if ke 2");
        //     this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
        // }
        // if (Mathf.Abs(this.transform.localPosition.x - wrongForm.transform.localPosition.x) <= 0.5f &&
        //    Mathf.Abs(this.transform.localPosition.y - wrongForm.transform.localPosition.y) <= 0.5f && 
        //    this.gameObject.name == correctForm.gameObject.name){

        //     Debug.Log(this.gameObject.name);
        //     Debug.Log(wrongForm.gameObject.name);
        //     Debug.Log("if ke 3");
        //     this.transform.position = new Vector3(correctForm.transform.position.x, correctForm.transform.position.y, correctForm.transform.position.z);

        // }else if (Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 0.5f &&
        //    Mathf.Abs(this.transform.localPosition.y - correctForm.transform.localPosition.y) <= 0.5f && 
        //    this.gameObject.name == wrongForm.gameObject.name)
        // {
        //     Debug.Log(this.gameObject.name);
        //     Debug.Log(correctForm.gameObject.name);
        //     Debug.Log("if ke 1");
        //     this.transform.position = new Vector3(correctForm.transform.position.x, correctForm.transform.position.y, correctForm.transform.position.z);

        // }

        // if(Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 100f &&
        //    Mathf.Abs(this.transform.localPosition.y - correctForm.transform.localPosition.y) <= 100f){

        //     Debug.Log("if ke 2");
        //     this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);

        // }
        var koordinatMouse = this.transform.position;
        int sumbuX = (int) koordinatMouse.x;
        var koordinatGambarBenar = correctForm.transform.position;
        var koordinatGambarSalah = wrongForm.transform.position;
        var koordinatGambarPrefab = posisiPrefabsForm.transform.position;
        int sumbuXGambarBenar = (int) koordinatGambarBenar.x;
        int sumbuXGambarSalah = (int) koordinatGambarSalah.x;
      

        if (Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 5f &&
           Mathf.Abs(this.transform.localPosition.y - correctForm.transform.localPosition.y) <= 5f)
        {
            Debug.Log(this.gameObject.name);
            Debug.Log(sumbuX);
            Debug.Log(sumbuXGambarBenar);
            Debug.Log(sumbuXGambarSalah);
            Debug.Log("if ke 1");
            this.transform.position = new Vector3(correctForm.transform.position.x, correctForm.transform.position.y, correctForm.transform.position.z);
            if(sumbuX == sumbuXGambarBenar){
                Debug.Log("gambar benar");
                finish = true;
                float scoreGet = ScoreManager.instance.AddPoint();
                StarsHandler.instance.SpawnStar();
            } else if(sumbuX == sumbuXGambarSalah){
                Debug.Log("gambar salah");
                finish = true;
            }

        }else if(Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 100f &&
           Mathf.Abs(this.transform.localPosition.y - correctForm.transform.localPosition.y) <= 100f){
            Debug.Log(sumbuX);
            Debug.Log(sumbuXGambarBenar);
            Debug.Log(sumbuXGambarSalah);
            Debug.Log("if ke 2");
            this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
        }
    }
}
