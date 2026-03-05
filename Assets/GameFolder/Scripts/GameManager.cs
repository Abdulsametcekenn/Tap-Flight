using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    private int BestScore;

    [Header("Game Over")]
    [SerializeField] Text GameOverScoreText;
    [SerializeField] Text GameOverBestScoreText;

    [SerializeField] Birdy birdy;

    private void Awake()
    {
        score = 0;
        BestScore = PlayerPrefs.GetInt("BestScore", 0);
    }
    public void ScoreUptade()
    {
        score++;
        scoreText.text = score.ToString();
    }
    public void GameOver()
    {
        if (birdy.GetIsDead())
        {
            GameOverScoreText.text = score.ToString();
            if (score > BestScore)
            {
                BestScore = score;
                PlayerPrefs.SetInt("BestScore", BestScore);
            }
            GameOverBestScoreText.text = BestScore.ToString();
        }
    }
    public void ReStartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
