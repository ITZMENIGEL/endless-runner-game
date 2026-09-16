using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    [SerializeField] private int startingScore = 0;
    private int currentScore = 0;
    private int coinsCollected = 0;
    private bool isGameActive = true;
    private bool hasShield = false;
    private float distanceTraveled = 0f;
    private PlayerController player;
    private UIManager uiManager;
    
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
        player = FindObjectOfType<PlayerController>();
        uiManager = FindObjectOfType<UIManager>();
    }
    
    private void Update()
    {
        if (isGameActive && player != null)
        {
            distanceTraveled += player.GetComponent<Rigidbody>().velocity.z * Time.deltaTime;
            currentScore = Mathf.Max(currentScore, (int)(distanceTraveled / 10));
        }
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
    
    public void ActivateShield()
    {
        hasShield = true;
        if (uiManager != null)
        {
            uiManager.ShowShieldActive();
        }
    }
    
    public bool HasShield()
    {
        return hasShield;
    }
    
    public void RemoveShield()
    {
        hasShield = false;
    }
    
    public void GameOver()
    {
        isGameActive = false;
        Time.timeScale = 0f;
        if (uiManager != null)
        {
            uiManager.ShowGameOver();
        }
    }
    
    public int GetScore() => currentScore;
    public int GetCoins() => coinsCollected;
    public bool IsGameActive() => isGameActive;
    public float GetDistance() => distanceTraveled;
}
