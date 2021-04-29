using UnityEngine;
using TMPro;

public class SizePanelUI : MonoBehaviour
{
    void Start()
    {
        TextMeshProUGUI[] texts = GetComponentsInChildren<TextMeshProUGUI>();
        for(int i = 0; i < texts.Length; i++)
        {
            texts[i].text = i + 2 + " X " + (i + 2);
        }
    }
}
