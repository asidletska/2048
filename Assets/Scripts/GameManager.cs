using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public TileBoard board;
    public CanvasGroup gameOver;
    private void Start()
    {
        NewGame();
    }
    public void NewGame()
    {
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
}
