using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefresherShowTiles : MonoBehaviour
{
    [SerializeField] Tile[] tiles = null;

    private void Start()
    {
        foreach(var tile in tiles)
        {
            tile.RefreshShow();
        }
    }
}
