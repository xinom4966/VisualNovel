using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextBehaviour : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private string fullText;
    [SerializeField] private float Delay;
    private string currentText = "";

    private void Start()
    {
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i <= fullText.Length; i++)
        {
            currentText = fullText.Substring(0,i);
            text.text = currentText;
            yield return new WaitForSeconds(Delay);
        }
    }
}
