using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Load a scene by name
    public void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Exit the application
    public void ExitApp()
    {
        Application.Quit();
    }
}
