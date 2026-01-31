using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class DayNightScript : MonoBehaviour
{
    //fields
    private bool fadeIn;
    private bool fadeOut;
    private float fadeSpeed = 1.5f;
    public TimerScript timer;
    public TMP_Text dayTracker;
    public int dayCount;
    public bool spawned;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //timer = new TimerScript();
        //dayTracker.enabled = false;
        spawned = true;
    }

    // Update is called once per frame
    void Update()
    {
        //causes the day text to fade out
        if (timer.minutes == 1 && spawned == true)
        {
            FadeOut();
            spawned = false;
            dayTracker.text = $"Day {dayCount}";
        }
        //causes the day text to fade in
        if (timer.minutes == 0 && (int)timer.seconds == 0 && spawned == false)
        {
            FadeIn();
            spawned = true;
            dayCount++;
            dayTracker.text = $"Day {dayCount}";
        }
        //causes the fading effect for the background
        if (fadeOut && GetComponent<Renderer>() != null)
        {
            Color color = GetComponent<Renderer>().material.color;
            float fadeAmout = color.a - (fadeSpeed * Time.deltaTime);
            color = new Color(color.r, color.g, color.b, fadeAmout);
            GetComponent<Renderer>().material.color = color;
            if (color.a <= 0)
            {
                fadeOut = false;
            }
        }
        //causes the fading effect for the text
        else if (fadeOut)
        {
            Color color = GetComponent<TMP_Text>().color;
            float fadeAmout = color.a - (fadeSpeed * Time.deltaTime);
            color = new Color(color.r, color.g, color.b, fadeAmout);
            GetComponent<TMP_Text>().color = color;
            if (color.a <= 0)
            {
                fadeOut = false;
            }
        }
        //causes the fading in effect for the background
        if (fadeIn && GetComponent<Renderer>() != null)
        {
            Color color = GetComponent<Renderer>().material.color;
            float fadeAmout = color.a + (fadeSpeed * Time.deltaTime);
            color = new Color(color.r, color.g, color.b, fadeAmout);
            GetComponent<Renderer>().material.color = color;
            if (color.a >= 1)
            {
                fadeIn = false;
            }
        }
        //causes the fading in effect for the text
        else if (fadeIn)
        {
            Color color = GetComponent<TMP_Text>().color;
            float fadeAmount = color.a + (fadeSpeed * Time.deltaTime);
            color = new Color(color.r, color.g, color.b, fadeAmount);
            GetComponent<TMP_Text>().color = color;
            if (color.a >= 1)
            {
                fadeIn = false;
            }
        }
    }

    /// <summary>
    /// method that toggles fade in mechanic
    /// </summary>
    private void FadeIn()
    {
        fadeIn = true;
        /*dayCount++;
        dayTracker.text = $"Day {dayCount}";
        dayTracker.enabled = true;*/
    }

    /// <summary>
    /// method that toggles the fade out mechanic
    /// </summary>
    private void FadeOut()
    {
        fadeOut = true;
        //dayTracker.enabled = false;
    }
}
