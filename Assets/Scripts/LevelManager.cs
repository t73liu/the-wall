using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadLevel(string name)
    {
        Debug.Log("Loading new scene: " + name);
        Brick.breakableBlockCount = 0;
        SceneManager.LoadScene(name);
    }

    public void QuitRequest()
    {
        Debug.Log("Quitting game for PC");
        Brick.breakableBlockCount = 0;
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        Brick.breakableBlockCount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BrickDestroyed()
    {
        if (Brick.breakableBlockCount <= 0)
        {
            LoadNextLevel();
        }
    }

    public void OpenSourceCode()
    {
        Application.OpenURL("https://github.com/t73liu/t73liu.github.io");
    }
}