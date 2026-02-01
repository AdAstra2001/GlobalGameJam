using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.Xml.XPath;

public class TransitionScreen: MonoBehaviour
{
    public TMP_Text correctText;
    public TMP_Text incorrectText;
    public TMP_Text timeOutText;
    public static TransitionScreen instance;
    public CanvasGroup group;
    public GameObject Background;
    public int secondsToWait = 2;
    public float fadeDuration = 1.5f;

    public enum ResultType
    {
        Correct,
        Wrong,
        TimeOut
    }

    private void DisableAllText()
    {
        correctText.gameObject.SetActive(false);
        incorrectText.gameObject.SetActive(false);
        timeOutText.gameObject.SetActive(false);
    }
    
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
        DisableAllText();
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
        yield return new WaitForSecondsRealtime(secondsToWait);
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

    public void ShowResult(ResultType result)
    {
        DisableAllText();
        switch (result)
        {
            case ResultType.Correct:
                correctText.gameObject.SetActive(true);
                break;
            case ResultType.Wrong:
                incorrectText.gameObject.SetActive(true);
                break;
            case ResultType.TimeOut:
                secondsToWait = 0;
                fadeDuration = 0;
                timeOutText.gameObject.SetActive(true);
                break;
        }
        FaidInUI();
    }

}
