using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    public GameObject[] powerPrefabs;
    public float pause = 5f;
    public float minTrans;
    public float maxTrans;

    void Start()
    {
        StartCoroutine(PowerSpawn());
    }

    IEnumerator PowerSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTrans, maxTrans);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(powerPrefabs[Random.Range(0, powerPrefabs.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(pause);
            Destroy(gameObject, 5f);
        }
    }
}
