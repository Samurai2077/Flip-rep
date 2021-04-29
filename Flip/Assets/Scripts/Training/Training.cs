using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Training : MonoBehaviour
{
    // Start is called before the first frame update
    public void Training2()
    {
        SceneController.LoadTraining2();
    }

    public void Training3()
    {
        SceneController.LoadTraining3();
    }

    public void EndTraining()
    {
        SceneController.LoadMenu();
    }
}
