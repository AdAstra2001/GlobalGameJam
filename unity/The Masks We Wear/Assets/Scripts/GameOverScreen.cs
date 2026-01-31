using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    //Loads the game scene
    public void RestartButton()
    {
        SceneManager.LoadSceneAsync(1);
    }

    //Loads main menu scene
    public void MenuButton()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
