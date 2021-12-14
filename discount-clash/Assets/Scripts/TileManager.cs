using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public static List<Tile> tileStorage = new List<Tile>();

    public static void GenerateTiles()
    {
        for(int x = 0; x <= 18; x++)
        {
            for(int y = 0; y <= 32; y++)
            {
                Tile t = new Tile(tileStorage.Count, new Vector2(x, y));
                tileStorage.Add(t);
            }
        }
    }

    void Start()
    {
        GenerateTiles();
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        foreach(Tile t in tileStorage)
        {
            Gizmos.DrawSphere(new Vector3(t.tilePos.x, 0, t.tilePos.y), 0.1f);
        }
    }
}

public class Tile 
{
    public int index;
    public Vector2 tilePos;

    public Tile(int index, Vector2 tilePos)
    {
        this.index = index;
        this.tilePos = tilePos;
    }
}