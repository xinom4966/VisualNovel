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
    private GlobalManager manager;
    private string username;

    private void Start()
    {
        manager = GlobalManager.instance;
        username = manager.GetUserName();
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i <= fullText.Length; i++)
        {
            if (fullText.Substring(i, 4) == "user")
            {
                currentText = username.Substring(0, i);
                text.text = currentText;
                fullText.Remove(i, 4);
                yield return new WaitForSeconds(Delay);
            }
            else
            {
                currentText = fullText.Substring(0, i);
                text.text = currentText;
                yield return new WaitForSeconds(Delay);
            }
        }
    }
}
