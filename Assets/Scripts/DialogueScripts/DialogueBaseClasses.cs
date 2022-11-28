using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace DialogueSystem
{
    
    public class DialogueBaseClasses : MonoBehaviour
    {
        public bool finished { get; private set; }
        protected IEnumerator WriteText(string input, TextMeshProUGUI textHolder, float delay,float delayBetweenLines)
        {

            for (int i = 0; i < input.Length; i++)
            {
                textHolder.text += input[i];
                yield return new WaitForSeconds(delay);
            }
            //yield return new WaitForSeconds(delayBetweenLines);
            yield return new WaitUntil(()=> Input.GetMouseButton(0));
            finished = true;
        }

    }
}

