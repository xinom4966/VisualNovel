using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnswerBox : MonoBehaviour
{
    [SerializeField] private TMP_InputField input;
    private GlobalManager manager;

    private void Start()
    {
        manager = GlobalManager.instance;
    }

    public void SubmitNameBtn()
    {
        manager.SetUserName(input.text);
    }
}
