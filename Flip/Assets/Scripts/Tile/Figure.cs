using UnityEngine;

public enum FigureType
{
    Circle,
    Square
}

[CreateAssetMenu(menuName = "TileInfo/Figure")]
public class Figure : ScriptableObject
{
    public Sprite image = null;
    public FigureType type;
}
