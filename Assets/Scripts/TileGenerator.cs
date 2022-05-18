using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathologicalGames;

public class TileGenerator : MonoBehaviour
{
    [SerializeField] private TileConfig tileConfig;
    [SerializeField] public float spawnPos = 0;
    [SerializeField] private GameObject[] tilePrefab;
    [SerializeField] private GameObject[] enemyPrefabs;
    private List<GameObject> activeTiles = new List<GameObject>();
    [SerializeField] private Transform player;
    private List<GameObject> activeEnemys = new List<GameObject>();
    [SerializeField] public float enemySpawnPosition = 0f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < tileConfig.startTiles; i++)
        {
            SpawnTile(Random.Range(0, tilePrefab.Length));
            SpawnEnemys(Random.Range(0, enemyPrefabs.Length));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.z - 60 > spawnPos - (tileConfig.startTiles * tileConfig.tileLength))
        {
            SpawnTile(Random.Range(0, tilePrefab.Length));
            DeleteTile();
        }

        if (player.position.z > enemySpawnPosition - 100)
        {
            SpawnEnemys(Random.Range(0, enemyPrefabs.Length));
        }

        DeleteEnemys();
    }

    private void SpawnTile(int tileIndex)
    {
        GameObject nextTiles = Instantiate(tilePrefab[tileIndex], transform.forward * spawnPos,
            transform.rotation);
        activeTiles.Add(nextTiles);
        spawnPos += tileConfig.tileLength;
    }

    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }

    private void SpawnEnemys(int enemyIndex)
    {
        GameObject plusEnemy = Instantiate(enemyPrefabs[enemyIndex], transform.forward * enemySpawnPosition,
            transform.rotation);
        enemySpawnPosition += tileConfig.enemyDistance;
        activeEnemys.Add(plusEnemy);
    }

    private void DeleteEnemys()
    {
        if (activeEnemys.Count > 5)
        {
            Destroy(activeEnemys[0]);
            activeEnemys.RemoveAt(0);
        }
    }
}