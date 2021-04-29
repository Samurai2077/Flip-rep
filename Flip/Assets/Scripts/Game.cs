using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] LevelConstruct levelSetter = null;
    [SerializeField] Level level = null;

    public void Start()
    {
        level.SetLevel(levelSetter.GetLevel());
    }
}