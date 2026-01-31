using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    //Loads the game scene
    public void PlayGame()
    {
      SceneManager.LoadSceneAsync(1);
    }
    //Quits the application
    public void QuitGame()
    {
      Debug.Log("Quit!");
      Application.Quit();
    }
}
