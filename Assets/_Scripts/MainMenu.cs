using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Continue()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void NewGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        //TODO: SessionContext.PlayerName = 
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
