using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    //Loads the game scene
    public void PlayGame()
    {
        GameManager.instance.IncrimentCounter();
        Debug.Log(GameManager.instance.successCounter);
        SceneManager.LoadSceneAsync(1);
    }
    //Quits the application
    public void QuitGame()
    {
      Debug.Log("Quit!");
      Application.Quit();
    }

    public void ResetGame()
    {
        SceneManager.LoadSceneAsync(0);
        Debug.Log("Game Reset!");
    }
}
