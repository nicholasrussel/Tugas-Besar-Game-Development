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
    public GameObject coinPrefab;

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
        int sumbuX = (int) koordinatMouse.x;
        int sumbuY = (int) koordinatMouse.y;
        var koordinatGambarBenar = correctForm.transform.position;
        var koordinatGambarSalah = wrongForm.transform.position;
        var koordinatGambarPrefab = posisiPrefabsForm.transform.position;
        int sumbuXPrefabCoin = (int) koordinatGambarPrefab.x;
        int sumbuYPrefabCoin = (int) koordinatGambarPrefab.y;
        int sumbuZPrefabCoin = (int) koordinatGambarPrefab.z;
        int sumbuXGambarBenar = (int) koordinatGambarBenar.x;
        int sumbuXGambarSalah = (int) koordinatGambarSalah.x;
        int sumbuYGambarBenar = (int) koordinatGambarBenar.y;
        int sumbuYGambarSalah = (int) koordinatGambarSalah.y;
      

        if (Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 75f &&
           Mathf.Abs(this.transform.localPosition.y - correctForm.transform.localPosition.y) <= 75f)
        {
            Debug.Log(this.gameObject.name);
            Debug.Log("sumbu X"+sumbuX);
            Debug.Log("sumbu X gambar benar"+sumbuXGambarBenar);
            Debug.Log("sumbu X gambar salah"+sumbuXGambarSalah);
            Debug.Log("if ke 1");
            this.transform.position = new Vector3(correctForm.transform.position.x, correctForm.transform.position.y, correctForm.transform.position.z);
            int selisih = sumbuXGambarBenar-sumbuX;
            int selisihSalah = sumbuXGambarSalah-sumbuX;
            if(((sumbuXGambarBenar-3) <= sumbuX && sumbuX  <= (sumbuXGambarBenar+3)) &&((sumbuYGambarBenar-3) <= sumbuY && sumbuY  <= (sumbuYGambarBenar+3)) || sumbuX == sumbuXGambarBenar){
                Debug.Log("gambar benar");
                finish = true;
                Vector3 randomPos = new Vector3(resetPosition.x,((resetPosition.y)-3), resetPosition.z);
                Instantiate(coinPrefab, randomPos, Quaternion.identity);
                float scoreAdd = ScoreManager.instance.AddPoint();
            } else if(((sumbuXGambarSalah-3) <= sumbuX &&  sumbuX  <= (sumbuXGambarSalah+3)) &&((sumbuYGambarSalah-3) <= sumbuY &&  sumbuY  <= (sumbuYGambarSalah+3)) || sumbuX == sumbuXGambarSalah){
                Debug.Log("gambar salah");
                finish = true;
                float scoreSubstract = ScoreManager.instance.SubtractPoint();
            }

        }else if(Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 1000f &&
            Mathf.Abs(this.transform.localPosition.y - correctForm.transform.localPosition.y) <= 1000f){
            Debug.Log(sumbuX);
            Debug.Log(sumbuXGambarBenar);
            Debug.Log(sumbuXGambarSalah);
            Debug.Log("if ke 2");
            this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
        }
    }
}
