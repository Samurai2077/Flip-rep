using UnityEngine;

[RequireComponent(typeof(Tile))]
public class TileShow : MonoBehaviour
{
    [SerializeField] SpriteRenderer renderFigure = null;
    [SerializeField] SpriteRenderer renderEmblem = null;
    [SerializeField] Tile tile = null;

    public void ShowTile()
    {
        renderFigure.sprite = tile.figure.image;
        renderFigure.color = new Color(tile.flip ? 0.2f : 0.8f, tile.flip ? 0.8f : 0.2f, 0.2f);
        if(tile.emblem != null)
            renderEmblem.sprite = tile.emblem.image;
    }

    public void ShowTileWin()
    {
        renderFigure.color = Color.black;
        renderEmblem.color = Color.red;
    }
}