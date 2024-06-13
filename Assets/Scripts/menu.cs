using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void OnPlayerHandler()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }
    public void OnScoreHandler()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1.0f;
    }
    public void OnExitHandler()
    {
        Application.Quit();
    }
}
