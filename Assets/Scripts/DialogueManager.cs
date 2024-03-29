using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] List<GameObject> texts = new();
    [SerializeField] List<GameObject> sprites = new();
    private int ind = 1;
    private GlobalManager manager;
    [SerializeField] private Endings ending;

    private void Start()
    {
        manager = GlobalManager.instance;
    }

    public void NextBtn()
    {
        if (ind >= texts.Count && ind >= sprites.Count)
        {
            //Insert scene transition here
            Debug.Log("Fin du dialogue");
        }
        else
        {
            texts[ind].SetActive(true);
            sprites[ind].SetActive(true);
            if (ind - 1 >= 0)
            {
                texts[ind - 1].SetActive(false);
                sprites[ind - 1].SetActive(false);
            }
        }
        ind++;
    }

    public Endings GetEnding()
    {
        return ending;
    }
}
