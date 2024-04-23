using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Tile", menuName = "Tiles/New Tile Type")]
public class TileType : ScriptableObject
{
    public string terrainName;
    public Sprite sprite;
    public int movementCost;
    public int avoidBonus;
    public bool isFlamable;
    public bool isConductive;
}
