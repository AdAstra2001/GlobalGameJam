using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TransitionScreen: MonoBehaviour
{
    public CanvasGroup group;
    public GameObject Background;
    public float fadeDuration = 1.5f;
    public static TransitionScreen Instance;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
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
