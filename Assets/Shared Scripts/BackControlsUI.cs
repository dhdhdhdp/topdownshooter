using UnityEngine;
using UnityEngine.SceneManagement;
public class BackControlsUI : MonoBehaviour
{
    public void BacktoStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}

