using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneController
{
    public static void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public static void LoadLevel()
    {
        SceneManager.LoadScene("Game");
    }

    public static void LoadTraining()
    {
        SceneManager.LoadScene("Training");
    }

    public static void LoadTraining2()
    {
        SceneManager.LoadScene("Training-2");
    }

    public static void LoadTraining3()
    {
        SceneManager.LoadScene("Training-3");
    }
}
