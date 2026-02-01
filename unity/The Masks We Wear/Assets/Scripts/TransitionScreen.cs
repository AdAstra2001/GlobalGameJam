using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TransitionScreen: MonoBehaviour
{
    public static TransitionScreen instance;
    public CanvasGroup group;
    public GameObject Background;
    public float fadeDuration = 1.5f;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        Background.SetActive(false);
    }

    public void FaidInUI()
    {
        Background.SetActive(true);
        group.alpha = 0f;
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        Debug.Log("E");
        yield return new WaitForSecondsRealtime(2);
        Debug.Log("OpenEnding");
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        float t = 0f;
        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            group.alpha = Mathf.Lerp(0f, 1f, t / fadeDuration);
            yield return null;
        }
        group.alpha = 1f;
    }    
    //Loads main menu scene
    public void ContinueButton()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadSceneAsync(currentSceneIndex+1);
    }

}
