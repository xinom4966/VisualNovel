using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{
    private string username;
    public static GlobalManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void SetUserName(string input)
    {
        username = input;
    }
}
