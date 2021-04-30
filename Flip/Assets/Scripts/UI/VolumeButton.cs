using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class VolumeButton : MonoBehaviour
{
    [SerializeField] Sprite volumeOn = null;
    [SerializeField] Sprite volumeOff = null;
    private Image image = null;
    private bool isInit = false;

    private void Start()
    {
        isInit = true;
        image = GetComponent<Image>();
        Refresh();
    }

    public void VolumeOnOff()
    {
        if (AudioController.Instance.GetVolume() > 0)
        {
            AudioController.Instance.SetVolume(0);
        }
        else
        {
            AudioController.Instance.SetVolume(1);
        }
        Refresh();
    }

    public void Refresh()
    {
        if (AudioController.Instance == null) return;

        if (AudioController.Instance.GetVolume() > 0)
            image.sprite = volumeOn;
        else
            image.sprite = volumeOff;

    }

    private void OnEnable()
    {
        if(isInit)
            Refresh();
    }
}
