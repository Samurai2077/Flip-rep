using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : LevelConstruct
{
    [SerializeField] FabricaTiles fabricaTiles = null;

    private List<int> levelInfo;
    private List<Tile> tiles;
    private int fieldSize = LevelSettings.FieldSize;
    private int level = LevelSettings.LevelNumber;

    public override List<Tile> GetLevel()
    {
        throw new System.NotImplementedException();
    }

    private void Awake()
    {
        LoadLevel();
    }

    private void LoadLevel()
    {
        levelInfo = LevelReader.Read(fieldSize, level);

        tiles = new List<Tile>();
        for (int x = 0, i = 0; x < fieldSize; x++)
            for (int y = 0; y < fieldSize; y++)
            {
                Tile tile = fabricaTiles.Get(levelInfo[i++], levelInfo[i++]);
                tile.transform.position = new Vector3(x - (fieldSize - 1) / 2f, y - (fieldSize - 1) / 2f, 0);
                tile.flip = true;
                tile.RefreshShow();
                tiles.Add(tile);
            }
    }
}
