using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsClick : MonoBehaviour
{
    public void BackMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }

}
