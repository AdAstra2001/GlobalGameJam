using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TransititionScreen : MonoBehaviour
{
    public CanvasGroup group;
    public float fadeDuration = 1.5f;


    private void Start()
    {
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
