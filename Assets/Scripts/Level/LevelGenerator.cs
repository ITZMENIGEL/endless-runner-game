using UnityEngine;
using System.Collections.Generic;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private GameObject groundTilePrefab;
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private GameObject powerUpPrefab;
    [SerializeField] private float tileLength = 10f;
    [SerializeField] private int initialTiles = 10;
    [SerializeField] private float obstacleSpawnRate = 0.4f;
    [SerializeField] private float coinSpawnRate = 0.3f;
    [SerializeField] private float powerUpSpawnRate = 0.05f;
    
    private Queue<GameObject> activeTiles = new Queue<GameObject>();
    private Vector3 lastTilePosition = Vector3.zero;
    private int tileCount = 0;
    private Transform player;
    
    private void Start()
    {
        player = FindObjectOfType<PlayerController>().transform;
        for (int i = 0; i < initialTiles; i++)
        {
            SpawnTile();
        }
    }
    
    private void Update()
    {
        // Spawn new tiles as player progresses
        if (player.position.z > lastTilePosition.z - 30f)
        {
            SpawnTile();
        }
        
        // Destroy tiles behind player
        if (activeTiles.Count > 0)
        {
            GameObject oldTile = activeTiles.Peek();
            if (oldTile.transform.position.z < player.position.z - 50f)
            {
                activeTiles.Dequeue();
                Destroy(oldTile);
            }
        }
    }
    
    private void SpawnTile()
    {
        GameObject newTile = Instantiate(groundTilePrefab, lastTilePosition, Quaternion.identity);
        activeTiles.Enqueue(newTile);
        lastTilePosition += Vector3.forward * tileLength;
        tileCount++;
        
        // Spawn obstacles
        if (Random.value < obstacleSpawnRate)
        {
            int laneCount = Random.Range(1, 3);
            for (int i = 0; i < laneCount; i++)
            {
                SpawnObstacle(lastTilePosition + Vector3.back * Random.Range(2f, 8f));
            }
        }
        
        // Spawn coins
        if (Random.value < coinSpawnRate)
        {
            for (int i = 0; i < Random.Range(1, 4); i++)
            {
                SpawnCoin(lastTilePosition + Vector3.back * Random.Range(2f, 8f));
            }
        }
        
        // Spawn power-ups
        if (Random.value < powerUpSpawnRate)
        {
            SpawnPowerUp(lastTilePosition + Vector3.back * 5f);
        }
    }
    
    private void SpawnObstacle(Vector3 position)
    {
        int lane = Random.Range(0, 3);
        position.x = lane * 1.5f - 1.5f;
        position.y = 0.5f;
        Instantiate(obstaclePrefab, position, Quaternion.identity);
    }
    
    private void SpawnCoin(Vector3 position)
    {
        int lane = Random.Range(0, 3);
        position.x = lane * 1.5f - 1.5f;
        position.y = 1f;
        Instantiate(coinPrefab, position, Quaternion.identity);
    }
    
    private void SpawnPowerUp(Vector3 position)
    {
        position.x = Random.Range(-1.5f, 1.5f);
        position.y = 1f;
        Instantiate(powerUpPrefab, position, Quaternion.identity);
    }
}
