using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public int levelToUnlock;
    int numberOfUnlockedLevels;

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            numberOfUnlockedLevels = PlayerPrefs.GetInt("levelsUnlocked");

            if (numberOfUnlockedLevels <= levelToUnlock)
            {
                PlayerPrefs.SetInt("levelsUnlocked", numberOfUnlockedLevels + 1);
            }
        }
    }
}
