using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreater : LevelConstruct
{
    [Header("Fabrics")]
    [SerializeField] FabricaTiles fabricaTiles = null;

    private int fieldSize;

    private List<Tile> tiles = null;

    public void Awake()
    {
        fieldSize = LevelSettings.FieldSize;
        Random.InitState(LevelSettings.LevelNumber);
    }

    public void CreateLevel()
    {
        tiles = new List<Tile>();
        for (int x = 0; x < fieldSize; x++)
            for(int y = 0; y < fieldSize; y++)
            {
                Tile tile = fabricaTiles.GetRandom();
                tile.transform.position = new Vector3(x - (fieldSize - 1) / 2f, y - (fieldSize - 1) / 2f, 0);
                tile.flip = true;
                tile.RefreshShow();
                tiles.Add(tile);
            }
    }

    public override List<Tile> GetLevel()
    {
        if(tiles == null) CreateLevel();
        return tiles;
    }
}
