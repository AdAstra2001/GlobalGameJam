using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int successCounter = 0;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);//to get rid of duplicated instances
        }

        instance = this;//Set instance
        DontDestroyOnLoad(this.gameObject);

    }

    public void IncrimentCounter()
    {
        successCounter++; //Updates the number of sucesses.
    }
}
