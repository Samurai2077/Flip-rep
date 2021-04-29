using UnityEngine;
using TMPro;

public class ButtonLevelSizeUI : MonoBehaviour
{
    public void Click()
    {
        string str = GetComponentInChildren<TextMeshProUGUI>().text;
        string[] strs = str.Split('X', ' ');
        LevelSettings.FieldSize = int.Parse(strs[0]);
    }
}