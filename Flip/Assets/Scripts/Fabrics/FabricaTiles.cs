using UnityEngine;

[CreateAssetMenu(menuName = "Fabrica/FabricaTiles")]
public class FabricaTiles : ScriptableObject
{
    [Header("Fabrics")]
    [SerializeField] FabricaFigures fabricaFigures = null;
    [SerializeField] FabricaEmblems fabricaEmblems = null;

    [Header("Tile Prefab")]
    [SerializeField] Tile tilePrefab = null;

    public Tile GetRandom()
    {
        Tile tile = Instantiate(tilePrefab);
        tile.figure = fabricaFigures.GetRandom();
        tile.emblem = fabricaEmblems.GetRandom();
        return tile;
    }

    public Tile Get(int indexFigure, int indexEmblem)
    {
        Tile tile = Instantiate(tilePrefab);
        tile.figure = fabricaFigures.Get(indexFigure);
        tile.emblem = fabricaEmblems.Get(indexEmblem);
        return tile;
    }
}
