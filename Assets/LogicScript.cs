using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text ScoreText;

    public GameObject gameOverScrene;

    [ContextMenu("Plus Score")]
    public void addScore(int score)
    {
        playerScore += score;
        ScoreText.text = playerScore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScrene.SetActive(true);
    }
}
