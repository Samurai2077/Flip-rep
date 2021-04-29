using System.Collections.Generic;
using UnityEngine;

public static class LevelReader
{
    public static List<int> Read(int size, int level)
    {
        TextAsset levelsString = (TextAsset)Resources.Load("Levels/Size-" + size);
        string[] levels = levelsString.text.Split();
        levels = levels[level].Split('-');
        List<int> levelInfoInt = new List<int>();
        foreach (var numStr in levels)
        {
            levelInfoInt.Add(int.Parse(numStr));
        }

        return levelInfoInt;
    }
}
