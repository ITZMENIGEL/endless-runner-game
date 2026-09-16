using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Text coinText;
    [SerializeField] private Text distanceText;
    [SerializeField] private Text shieldText;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private Text finalScoreText;
    [SerializeField] private Text finalCoinsText;
    
    private GameManager gameManager;
    
    private void Start()
    {
        gameManager = GameManager.Instance;
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
        }
    }
    
    private void Update()
    {
        if (!GameManager.Instance.IsGameActive()) return;
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
        
        if (distanceText != null)
        {
            distanceText.text = "Distance: " + ((int)(gameManager.GetDistance() / 10)).ToString();
        }
    }
    
    public void ShowShieldActive()
    {
        if (shieldText != null)
        {
            shieldText.gameObject.SetActive(true);
            Invoke(nameof(HideShield), 3f);
        }
    }
    
    private void HideShield()
    {
        if (shieldText != null)
        {
            shieldText.gameObject.SetActive(false);
        }
    }
    
    public void ShowGameOver()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }
        if (finalScoreText != null)
        {
            finalScoreText.text = "Final Score: " + gameManager.GetScore();
        }
        if (finalCoinsText != null)
        {
            finalCoinsText.text = "Coins: " + gameManager.GetCoins();
        }
    }
    
    public void RestartGame()
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
    
    public void QuitGame()
    {
        Time.timeScale = 1f;
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
