using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{
    private string username;
    public static GlobalManager instance;
    private List<Endings> endings;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        username = "Simon";
        endings = new List<Endings>();
    }

    public void SetUserName(string input)
    {
        if (input != null)
        {
            username = input;
        }
    }

    public string GetUserName()
    {
        return username;
    }
}

public enum Endings
{
    PerduDansLaMaison,
    EngloutiParLaMaison,
    NouvelleMaison,
    Maison,
    Evasif
}
