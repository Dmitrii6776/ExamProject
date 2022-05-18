using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TileConfig", menuName = "Configs/Tile/Create Tile Config")]
public class TileConfig : ScriptableObject
{
    [SerializeField] public float tileLength = 100;
    [SerializeField] public int startTiles = 5;
    [SerializeField] public int enemyDistance = 40;
}