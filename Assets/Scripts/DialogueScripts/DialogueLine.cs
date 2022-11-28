using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace DialogueSystem
{
    public class DialogueLine : DialogueBaseClasses
    {
        [Header("Text Options")]
        [SerializeField] private string input;

        private TextMeshProUGUI textHolder;

        [Header("Time Parameter")]
        [SerializeField] float delay;
        [SerializeField] float delayBetweenLines;

        private void Awake()
        {
            textHolder = GetComponent<TextMeshProUGUI>();
            textHolder.text = "";

        }
        private void Start()
        {
            StartCoroutine(WriteText(input, textHolder, delay, delayBetweenLines));
        }
    }
}

