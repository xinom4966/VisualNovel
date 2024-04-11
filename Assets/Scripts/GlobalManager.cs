using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{
    private string username;
    public static GlobalManager instance;
    private List<Endings> endings;
    private int endingCount;
    private bool gotEnding;
    private bool hasAllEndings;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        username = "Simon";
        endings = new List<Endings>();
        endingCount = 0;
        gotEnding = false;
    }

    private void Update()
    {
        AddEnding();
        if (endings.Count == 5)
        {
            hasAllEndings = true;
        }
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
        if (currentDialogue.GetEnding() == Endings.PasUnEnding)
        {
            gotEnding = true;
            return;
        }
        if (!gotEnding)
        {
            if (!endings.Contains(currentDialogue.GetEnding()))
            {
                endings.Add(currentDialogue.GetEnding());
                endingCount++;
                gotEnding = true;
            }
        }
    }

    public void SetHasAllEndings(bool value)
    {
        hasAllEndings = value;
        SetUserName("Simon");
    }

    public bool GetHasAllEndings()
    {
        return hasAllEndings;
    }

    public int GetEndingCount()
    {
        return endingCount;
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
