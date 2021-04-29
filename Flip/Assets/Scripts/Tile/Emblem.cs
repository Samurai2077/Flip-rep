using UnityEngine;

public enum EmblemType
{
    Circle,
    Cross,
    Heart,
    Settings,
    Music
}

[CreateAssetMenu(menuName = "TileInfo/Emblem")]
public class Emblem : ScriptableObject
{
    public Sprite image = null;
    public EmblemType type;
}
