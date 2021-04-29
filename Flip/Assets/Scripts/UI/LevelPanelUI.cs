using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LevelPanelUI : MonoBehaviour
{
    [SerializeField] GameObject buttonPrefab = null;
    [SerializeField] Button prevList = null;

    private int currentList = 0;

    void Start()
    {
        for (int i = 0; i < 9; i++)
        {
            Instantiate(buttonPrefab, transform);
        }
        RefreshShow();
    }

    void RefreshShow()
    {
        prevList.interactable = currentList != 0;

        TextMeshProUGUI[] texts = GetComponentsInChildren<TextMeshProUGUI>();
        Button[] buttons = GetComponentsInChildren<Button>();
        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].text = (i + 1 + currentList * 9).ToString();
            buttons[i].interactable = (i + 1 + currentList * 9) <= PlayerPrefs.GetInt("Size" + LevelSettings.FieldSize, 1);
        }
    }

    public void NextList()
    {
        currentList++;
        RefreshShow();
    }

    public void PrevList()
    {
        currentList--;
        RefreshShow();
    }

    private void OnEnable()
    {
        currentList = (PlayerPrefs.GetInt("Size" + LevelSettings.FieldSize, 1) - 1) / 9;
        RefreshShow();
    }
}
