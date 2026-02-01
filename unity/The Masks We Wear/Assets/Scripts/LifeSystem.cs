using UnityEngine;

public class LifeSystem : MonoBehaviour
{

    private int Lives = 3;
    public static LifeSystem Instance;
    public GameObject heartsUI;
    public GameObject gameOverUI;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    private void Start()
    {
      heartsUI.SetActive(true);
      gameOverUI.SetActive(false);
    }
    private void Awake()
    { // Pattern to ensure a single instance of LifeSystem
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Instance = this;
        }
    }
    public void LoseLife()
    { // Method to reduce lives
        Lives--;
        Debug.Log("Lives remaining: " + Lives);
        if (Lives <= 0)
        {
            Debug.Log("Game Over!");

        }
    }

    private void Update()
    {
        //Check lives and update hearts UI
        if (Lives >= 3)
        {
            heart1.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(true);
        }
        else if (Lives == 2)
        {
            heart1.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(false);
        }
        else if (Lives == 1)
        {
            heart1.SetActive(true);
            heart2.SetActive(false);
            heart3.SetActive(false);
        }
        else if (Lives <= 0)
        { // Trigger game over
            GameOver();
        }
    }
    //Game over method
    private void GameOver()
    {
        heartsUI.SetActive(false);
        gameOverUI.SetActive(true);
    }
}
    

