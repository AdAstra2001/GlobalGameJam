using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class DayNightScript : MonoBehaviour
{
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
        if (timer.minutes == 15 && spawned == true)
        {
            FadeOut();
            spawned = false;
            dayTracker.text = $"Day {dayCount}";
        }
        if (timer.minutes == 14 && (int)timer.seconds == 50 && spawned == false)
        {
            FadeIn();
            spawned = true;
            dayCount++;
            dayTracker.text = $"Day {dayCount}";
        }
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

    private void FadeIn()
    {
        fadeIn = true;
        /*dayCount++;
        dayTracker.text = $"Day {dayCount}";
        dayTracker.enabled = true;*/
    }

    private void FadeOut()
    {
        fadeOut = true;
        //dayTracker.enabled = false;
    }
}
