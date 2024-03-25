using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] List<GameObject> texts = new();
    private int indice = 1;


    public void NextBtn()
    {
        if (indice >= texts.Count || texts[indice] == null)
        {
            //Insert scene transition here
        }
        else
        {
            texts[indice].SetActive(true);
            if (indice - 1 >= 0)
            {
                texts[indice - 1].SetActive(false);
            }
        }
        indice++;
    }
}
