using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI endingsDisplay;
    [SerializeField] List<GameObject> texts = new();
    [SerializeField] List<GameObject> sprites = new();
    private int ind = 1;
    private GlobalManager manager;
    [SerializeField] private Endings ending;
    [SerializeField] private List<string> namesForTheChoices;
    [SerializeField] private List<string> ScenesToLoad;
    public static DialogueManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        manager = GlobalManager.instance;
        endingsDisplay.text = "Endings: " + manager.GetEndingCount() + " / 5";
    }

    public void NextBtn()
    {
        if (ind >= texts.Count && ind >= sprites.Count)
        {
            if (manager.GetHasAllEndings())
            {
                manager.SetHasAllEndings(false);
                SceneManager.LoadScene("Debut-Secret");
            }
            else
            {
                SceneManager.LoadScene(ScenesToLoad[0]);
            }
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

    public string GetNextScenesByInd(int ind)
    {
        return ScenesToLoad[ind];
    }

    public string GetChoiceNamesByInd(int ind)
    {
        return namesForTheChoices[ind];
    }

    public void Quit()
    {
        Application.Quit();
    }
}
