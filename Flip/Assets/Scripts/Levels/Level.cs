using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class Level : MonoBehaviour
{
    public static Level CurrentLevel = null;

    [SerializeField] Transform table = null;

    public UnityEvent Win;
    public UnityEvent<bool> IsCancelMove;

    private List<Tile> tiles = null;
    private Stack<Tile> turns = new Stack<Tile>();
    private bool isWin = false;

    public void Start()
    {
        CurrentLevel = this;
    }

    public void SetLevel(List<Tile> level)
    {
        tiles = level;
        table.localScale = new Vector3(Mathf.Sqrt(level.Count), Mathf.Sqrt(level.Count), 1);
        Camera.main.orthographicSize = Mathf.Sqrt(level.Count) + 1;
        int difficult = Mathf.Min(Mathf.Max((int)Mathf.Sqrt(LevelSettings.LevelNumber) - 1, 1), 15);
        do
        {
            for (int i = 0; i < difficult; i++) Shuffle();
            difficult++;
        } while (CheckWin());
    }

    public void Shuffle()
    {
        Flip(tiles[Random.Range(0, tiles.Count)]);
    }

    public void Turn(Tile tile)
    {
        if (isWin) return;

        AudioController.Instance.PlayAudioClickTile();
        turns.Push(tile);
        IsCancelMove?.Invoke(true);
        Flip(tile);
        if (CheckWin())
        {
            WinLevel();
        }
    }

    public void CancelTurn()
    {
        if (isWin) return;
        Flip(turns.Pop());
        if(turns.Count == 0)
        {
            IsCancelMove?.Invoke(false);
        }
    }

    private void Flip(Tile tile)
    {
        foreach (Tile tl in tiles)
        {
            if (Tile.Equals(tl, tile))
            {
                tl.Flip();
            }
        }
    }

    private bool CheckWin()
    {
        return tiles.All(t => t.flip);
    }

    public void SkipLevel()
    {
        foreach(var tile in tiles)
        {
            tile.flip = true;
        }
        WinLevel();
    }

    public void WinLevel()
    {
        if (PlayerPrefs.GetInt("Size" + LevelSettings.FieldSize, 1) <= LevelSettings.LevelNumber)
        {
            PlayerPrefs.SetInt("Size" + LevelSettings.FieldSize, LevelSettings.LevelNumber + 1);
        }
        AudioController.Instance.PlayAudioWin();
        Win?.Invoke();
        isWin = true;
        IsCancelMove?.Invoke(false);
        foreach (var i in tiles)
        {
            i.ShowWinColor();
        }

        PlayerPrefs.SetInt("CountLevelEnd", PlayerPrefs.GetInt("CountLevelEnd", 0) + 1);
        AdsController.Instance.ShowAdsNoReward();
    }
}
