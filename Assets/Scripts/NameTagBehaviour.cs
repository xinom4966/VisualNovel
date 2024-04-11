using TMPro;
using UnityEngine;

public class NameTagBehaviour : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameTag;
    private GlobalManager globalManager;

    private void Start()
    {
        globalManager = GlobalManager.instance;
        nameTag.text = globalManager.GetUserName() + " :";
    }
}
