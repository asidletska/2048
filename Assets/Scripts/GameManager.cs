using UnityEngine;
using System.Collections;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TileBoard board;
    public CanvasGroup gameOver;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreText;
    public int score;
    private void Start()
    {       
        NewGame();
    }
    public void NewGame()
    {
        SetScore(0);
        bestScoreText.text = LoadHiscore().ToString();
        gameOver.alpha = 0f;
        gameOver.interactable = false;
        board.ClearBoard();
        board.CreateTile();
        board.CreateTile();
        board.enabled = true;
    }
    public void GameOver()
    {        
        board.enabled = false;
        gameOver.interactable = true;
        StartCoroutine(Fade(gameOver, 1f, 1f));
    }
    private IEnumerator Fade(CanvasGroup canvasGroup, float to, float delay)
    {
        yield return new WaitForSeconds(delay);
        float elasped = 0f;
        float duration = 0.5f;
        float from = canvasGroup.alpha;

        while (elasped < duration)
        {
            canvasGroup.alpha = Mathf.Lerp(from, to, elasped / duration);
            elasped += Time.deltaTime;
            yield return null;
        }
        canvasGroup.alpha = to;
    }
    public void IncreaseScore(int points)
    {
        SetScore(score + points);
    }
    private void SetScore(int score)
    {
        this.score = score;
        scoreText.text = score.ToString();
        SaveHiscore();
    }
    private void SaveHiscore()
    {
        int hiscore = LoadHiscore();

        if (score > hiscore)
        {
            PlayerPrefs.SetInt("Best score", score);            
        }
    }
    private int LoadHiscore()
    {
        //scoreManager.SaveHighScore("", score);
        return PlayerPrefs.GetInt("Best score", 0);
    }
}
