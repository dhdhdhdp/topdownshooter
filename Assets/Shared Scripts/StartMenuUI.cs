using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuUI : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("ArenaKeuzen");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
