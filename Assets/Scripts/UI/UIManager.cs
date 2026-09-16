using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI coinText;
    [SerializeField] private GameObject gameOverPanel;
    
    private GameManager gameManager;
    
    private void Start()
    {
        gameManager = GameManager.Instance;
        gameOverPanel.SetActive(false);
    }
    
    private void Update()
    {
        UpdateUI();
    }
    
    private void UpdateUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + gameManager.GetScore();
        }
        
        if (coinText != null)
        {
            coinText.text = "Coins: " + gameManager.GetCoins();
        }
    }
    
    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true);
    }
    
    public void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
