using System.Collections.Generic;
using UnityEngine;

public abstract class LevelConstruct : MonoBehaviour
{
    public abstract List<Tile> GetLevel();
}
