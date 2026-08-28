using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmanu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Scene01");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
