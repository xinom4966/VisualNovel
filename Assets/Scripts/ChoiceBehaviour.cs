using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChoiceBehaviour : MonoBehaviour
{
    private DialogueManager manager;
    [SerializeField] private List<Button> buttons = new();

    private void Start()
    {
        manager = DialogueManager.Instance;
        PutNamesOnButtons();
    }

    private void PutNamesOnButtons()
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            buttons[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = manager.GetChoiceNamesByInd(i);
        }
    }

    public void ChoiceOne()
    {
        SceneManager.LoadScene(manager.GetNextScenesByInd(0));
    }

    public void ChoiceTwo()
    {
        SceneManager.LoadScene(manager.GetNextScenesByInd(1));
    }
}
