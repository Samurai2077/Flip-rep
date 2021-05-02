using System.Diagnostics;
using UnityEngine;

public class VKButton : MonoBehaviour
{
    string site = "https://vk.com/seleron1";

    public void OpenSite()
    {
        Process prc = new Process();
        prc.StartInfo.FileName = site;
        prc.StartInfo.UseShellExecute = true;
        prc.Start();
    }
}