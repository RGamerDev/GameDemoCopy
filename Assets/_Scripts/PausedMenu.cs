using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public Transform Player;
    public static GameObject PauseMenuUI;
    public GameObject Coin;

    public void Resume()
    {
        resume();
    }

    static public void resume()
    {
        Debug.Log("Resuming game...");
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public static void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void SaveMenu()
    {
        Time.timeScale = 1f;
        PauseMenuUI.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting...");
        PauseMenuUI.SetActive(false);
        SceneManager.LoadScene(0);
    }

    public void Retry()
    {
        PauseMenuUI.SetActive(false);
        Player.position = new Vector3{x = 0f, y = 1.14f, z = 0f };
        Player.rotation = new Quaternion {y = 0f };
        Time.timeScale = 1f;
    }
}
