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
}
