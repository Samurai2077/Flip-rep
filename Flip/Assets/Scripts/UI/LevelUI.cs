using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelUI : MonoBehaviour
{
    [SerializeField] Button nextLevelButton = null;
    [SerializeField] Button cancelMoveButton = null;
    [SerializeField] TextMeshProUGUI levelNumber = null;

    public void Start()
    {
        nextLevelButton.interactable = false;
        cancelMoveButton.interactable = false;
        levelNumber.text = "Level\n" + LevelSettings.LevelNumber;
    }

    public void LoadMenu()
    {
        SceneController.LoadMenu();
    }

    public void LoadNextLevel()
    {
        LevelSettings.LevelNumber++;
        SceneController.LoadLevel();
    }

    public void SetActiveCancelMoveButton(bool active)
    {
        cancelMoveButton.interactable = active;
    }

    public void UnlockLevel()
    {
        nextLevelButton.interactable = true;
    }
}