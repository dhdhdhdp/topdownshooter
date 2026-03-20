using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuUI : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("ArenaKeuze");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
