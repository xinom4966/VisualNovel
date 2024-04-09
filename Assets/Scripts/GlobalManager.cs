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
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        username = "Simon";
        endings = new List<Endings>();
    }

    private void Update()
    {
        AddEnding();
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

    public void AddEnding()
    {
        DialogueManager currentDialogue = DialogueManager.Instance;
        if (currentDialogue.GetEnding() != Endings.PasUnEnding)
        {
            return;
        }
        endings.Add(currentDialogue.GetEnding());
    }
}

public enum Endings
{
    PerduDansLaMaison,
    EngloutiParLaMaison,
    NouvelleMaison,
    Maison,
    Evasif,
    PasUnEnding
}
