using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelUI : MonoBehaviour
{
    [SerializeField] Button nextLevelButton = null;
    [SerializeField] Button cancelMoveButton = null;
    [SerializeField] Button skipLevel = null;
    [SerializeField] TextMeshProUGUI levelNumber = null;

    public void Start()
    {
        AdsController.Instance.RewardAdsShowed.AddListener(SkipLevel);
        nextLevelButton.interactable = false;
        cancelMoveButton.interactable = false;
        levelNumber.text = "Level\n" + LevelSettings.LevelNumber;
    }

    public void Update()
    {
        skipLevel.gameObject.SetActive(AdsController.Instance.RewardAdsIsReady());
    }

    public void ShowRewardAds()
    {
        AdsController.Instance.ShowAdsReward();
    }

    public void SkipLevel()
    {
        Level.CurrentLevel?.SkipLevel();
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

    public void OnDestroy()
    {
        AdsController.Instance.RewardAdsShowed.RemoveAllListeners();
    }
}