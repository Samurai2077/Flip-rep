using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] AudioSource backGroundMusic = null;
    [SerializeField] AudioSource clickTile = null;
    [SerializeField] AudioSource win = null;

    public static AudioController Instance = null;
    public string Author = "Music: https://www.bensound.com/royalty-free-music";

    public void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            SetVolume(PlayerPrefs.GetFloat("Volume", 1));
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayAudioClickTile()
    {
        clickTile.pitch = Random.Range(0.7f, 1.3f);
        clickTile.Play();
    }

    public void PlayAudioWin()
    {
        win.pitch = Random.Range(0.9f, 1.1f);
        win.Play();
    }

    public void SetVolume(float value)
    {
        PlayerPrefs.SetFloat("Volume", value);
        backGroundMusic.volume = value;
        clickTile.volume = value;
        win.volume = value;
    }

    public float GetVolume() => PlayerPrefs.GetFloat("Volume", 1);
}
