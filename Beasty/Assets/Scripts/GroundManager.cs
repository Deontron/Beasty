using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GroundManager : MonoBehaviour
{
    [SerializeField] private Tilemap[] tilemaps;
    [SerializeField] private Tile[] hexagons;
    [SerializeField] private int width;

    private Tilemap tilemap;
    private Tile tile;
    private Vector3Int position;
    void Start()
    {
        SetGround();
    }

    private void SetGround()
    {
        for (int i = -4; i < width; i++)
        {
            for (int j = -4; j < width - (width / 7); j++)
            {
                if (j > (width - (width / 7)) / 2)
                {
                    if (i > (width / 2))
                    {
                        tile = hexagons[0];
                        tilemap = tilemaps[2];
                    }
                    else
                    {
                        tile = hexagons[1];
                        tilemap = tilemaps[1];
                    }
                }
                else
                {
                    tile = hexagons[2];
                    tilemap = tilemaps[0];
                }
                position = new Vector3Int(j, i);
                tilemap.SetTile(position, tile);
            }
        }
    }
}
