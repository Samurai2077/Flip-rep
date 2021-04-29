using UnityEngine;
using TMPro;

public class ButtonLevelUI : MonoBehaviour
{
    public void Click()
    {
        string str = GetComponentInChildren<TextMeshProUGUI>().text;
        string[] strs = str.Split('X', ' ');
        LevelSettings.LevelNumber = int.Parse(strs[0]);
        SceneController.LoadLevel();
    }
}
