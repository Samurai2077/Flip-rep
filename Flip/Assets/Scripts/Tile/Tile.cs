using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] TileShow tileShow = null;

    public Figure figure = null;
    public Emblem emblem = null;
    public bool flip = false;

    public void Click()
    {
        if(Level.CurrentLevel != null)
            Level.CurrentLevel.Turn(this);
        else
        {
            Flip();
        }
    }

    public void Flip()
    {
        flip = !flip;
        RefreshShow();
    }

    public void ShowWinColor()
    {
        tileShow.ShowTileWin();
    }

    public void RefreshShow()
    {
        tileShow.ShowTile();
    }

    public static bool Equals(Tile first, Tile second)
    {
        if (first.figure == null || second.figure == null)
        {
            throw new System.NullReferenceException();
        }

        if (first.figure.type == second.figure.type)
            return true;

        if (first.emblem == null || second.emblem == null)
            return false;

        return first.emblem.type == second.emblem.type;
    }
}
