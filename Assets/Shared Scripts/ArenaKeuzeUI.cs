using UnityEngine;
using UnityEngine.SceneManagement;

public class ArenaKeuzeUI : MonoBehaviour
{
    public void LoadArena()
    {
        SceneManager.LoadScene("Arena 1");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
