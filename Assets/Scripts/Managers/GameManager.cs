using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    [SerializeField] private int startingScore = 0;
    private int currentScore = 0;
    private int coinsCollected = 0;
    private bool isGameActive = true;
    
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
    private void Start()
    {
        currentScore = startingScore;
    }
    
    public void AddScore(int amount)
    {
        if (isGameActive)
        {
            currentScore += amount;
        }
    }
    
    public void CollectCoin()
    {
        coinsCollected++;
        AddScore(10);
    }
    
    public void GameOver()
    {
        isGameActive = false;
        Debug.Log("Game Over! Final Score: " + currentScore);
    }
    
    public int GetScore() => currentScore;
    public int GetCoins() => coinsCollected;
    public bool IsGameActive() => isGameActive;
}
