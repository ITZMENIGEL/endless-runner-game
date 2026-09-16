using UnityEngine;
using System.Collections.Generic;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private GameObject groundTilePrefab;
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private float tileLength = 10f;
    [SerializeField] private int tilesToGenerate = 50;
    [SerializeField] private float spawnRate = 0.3f;
    
    private Queue<GameObject> activeTiles = new Queue<GameObject>();
    private Vector3 lastTilePosition = Vector3.zero;
    private int tileCount = 0;
    
    private void Start()
    {
        for (int i = 0; i < tilesToGenerate; i++)
        {
            SpawnTile();
        }
    }
    
    private void Update()
    {
        // Check if we need to spawn more tiles
        if (tileCount < tilesToGenerate + 10)
        {
            SpawnTile();
        }
    }
    
    private void SpawnTile()
    {
        GameObject newTile = Instantiate(groundTilePrefab, lastTilePosition, Quaternion.identity);
        activeTiles.Enqueue(newTile);
        lastTilePosition += Vector3.forward * tileLength;
        tileCount++;
        
        // Randomly spawn obstacles and coins
        if (Random.value > spawnRate)
        {
            SpawnObstacle(lastTilePosition);
        }
        else if (Random.value > 0.5f)
        {
            SpawnCoin(lastTilePosition);
        }
    }
    
    private void SpawnObstacle(Vector3 position)
    {
        position.x = Random.Range(-1.5f, 1.5f);
        position.y = 0.5f;
        Instantiate(obstaclePrefab, position, Quaternion.identity);
    }
    
    private void SpawnCoin(Vector3 position)
    {
        position.x = Random.Range(-1.5f, 1.5f);
        position.y = 1f;
        Instantiate(coinPrefab, position, Quaternion.identity);
    }
}
