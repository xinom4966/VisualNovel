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
        if (input.text == "Will" || input.text == "Williams")
        {
            manager.SetUserName("William");
            input.text = "Nom Enregistré: " + "William";
        }
        else
        {
            manager.SetUserName(input.text);
            input.text = "Nom Enregistré : " + input.text;
        }
    }
}
