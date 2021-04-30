using System.Diagnostics;
using UnityEngine;

public class VKButton : MonoBehaviour
{
    string site = "https://vk.com/seleron1";

    public void OpenSite()
    {
        Process.Start(site);
    }
}