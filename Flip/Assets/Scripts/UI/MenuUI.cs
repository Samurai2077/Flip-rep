using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUI : MonoBehaviour
{
    public void Play()
    {
        SceneController.LoadLevel();
    }

    public void Training()
    {
        SceneController.LoadTraining();
    }

    public void Exit()
    {
        Application.Quit();
    }
}
