using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.Events;

public class AdsController : MonoBehaviour, IUnityAdsListener
{
    public UnityEvent RewardAdsShowed;
    public static AdsController Instance = null;
    private bool isStartCoroutine = false;
    public bool adsIsShow = false;

    public void Awake()
    {
        if(Instance == null)
        {
            Advertisement.AddListener(this);
            Advertisement.Initialize("4110327", false);
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void OnUnityAdsDidError(string message)
    {
        return;
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (placementId != "Rewarded_Android") return;
        if(showResult == ShowResult.Finished)
        {
            RewardAdsShowed?.Invoke();
        }
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        return;
    }

    public void OnUnityAdsReady(string placementId)
    {
        return;
    }

    public bool RewardAdsIsReady()
    {
        return Advertisement.IsReady("Rewarded_Android");
    }

    public void ShowAdsNoReward()
    {
        if (Advertisement.IsReady("Interstitial_Android") && PlayerPrefs.GetInt("CountLevelEnd", 0) >= 10 && !isStartCoroutine)
        {
            StartCoroutine(ShowAdsNoRewardCoroutine());
        }
    }

    public void ShowAdsReward()
    {
        if (Advertisement.IsReady("Rewarded_Android"))
        {
            Advertisement.Show("Rewarded_Android");
        }
    }

    private IEnumerator ShowAdsNoRewardCoroutine()
    {
        isStartCoroutine = true;
        yield return new WaitForSeconds(1f);
        while(!Advertisement.IsReady())
        {
            yield return null;
        }
        Advertisement.Show("Interstitial_Android");
        PlayerPrefs.SetInt("CountLevelEnd", 0);
        isStartCoroutine = false;
    }
}
