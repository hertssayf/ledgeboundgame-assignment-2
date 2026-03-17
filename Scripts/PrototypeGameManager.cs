using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using SupanthaPaul;

public class PrototypeGameManager : MonoBehaviour
{
    public static PrototypeGameManager Instance { get; private set; }

    [Header("Level Setup")]
    [SerializeField] private int startingLives = 3;
    [SerializeField] private string levelLabel = "Level 1";
    [SerializeField] private string nextSceneName = "";

    [Header("UI")]
    [SerializeField] private Text livesText;
    [SerializeField] private Text levelText;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject levelCompletePanel;

    private int currentLives;
    private bool gameEnded;
    private PlayerController playerController;

    public int CurrentLives => currentLives;
    public bool GameEnded => gameEnded;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    private void Start()
    {
        Time.timeScale = 1f;
        currentLives = startingLives;
        playerController = FindFirstObjectByType<PlayerController>();

        if (playerController != null)
        {
            playerController.canMove = true;
            playerController.isCurrentlyPlayable = true;
        }

        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);

        if (levelCompletePanel != null)
            levelCompletePanel.SetActive(false);

        RefreshUI();
    }

    public void PlayerHit(PrototypePlayer player)
    {
        if (gameEnded || player == null)
            return;

        currentLives--;
        RefreshUI();

        if (currentLives <= 0)
        {
            ShowGameOver();
            return;
        }

        player.Respawn();
    }

    public void LevelComplete()
    {
        if (gameEnded)
            return;

        gameEnded = true;
        FreezePlayer();

        if (levelCompletePanel != null)
            levelCompletePanel.SetActive(true);

        Debug.Log("Level complete");
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadNextLevelOrRestart()
    {
        Time.timeScale = 1f;

        if (!string.IsNullOrWhiteSpace(nextSceneName))
        {
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void ShowGameOver()
    {
        gameEnded = true;
        FreezePlayer();

        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);

        Debug.Log("Game over");
    }

    private void FreezePlayer()
    {
        if (playerController != null)
        {
            playerController.canMove = false;
            playerController.isCurrentlyPlayable = false;
        }

        Rigidbody2D playerRb = FindFirstObjectByType<Rigidbody2D>();
        if (playerRb != null)
            playerRb.linearVelocity = Vector2.zero;
    }

    private void RefreshUI()
    {
        if (livesText != null)
            livesText.text = "Lives: " + currentLives;

        if (levelText != null)
            levelText.text = levelLabel;
    }
}
