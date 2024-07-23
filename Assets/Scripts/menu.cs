using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void OnScoreHandler()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1.0f;
    }

}
