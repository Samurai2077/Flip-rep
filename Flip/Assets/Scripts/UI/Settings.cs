using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] Slider volumeSlider = null;

    public void OnEnable()
    {
        volumeSlider.value = AudioController.Instance.GetVolume();
    }

    public void SetVolume(float value)
    {
        AudioController.Instance.SetVolume(value);
    }
}
