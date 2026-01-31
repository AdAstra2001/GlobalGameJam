using TMPro;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public TMP_Text timerText;
    public float minutes;
    //public TMP_Text days;
    public int numberOfDays;
    public float seconds;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        minutes = 15;
        seconds = 0;
        numberOfDays = 0;
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (seconds <= 0)
        {
            minutes--;
            seconds = 59;
        }
        seconds -= Time.deltaTime;
        UpdateUI();
    }

    public void UpdateUI()
    {
        if (seconds == 0)
        {
            timerText.text = $"Time remaining: {(int)minutes}:00";
        }
        else if (seconds < 10)
        {
            timerText.text = $"Time remaining: {(int)minutes}:0{(int)seconds}";
        }
        else
        {
            timerText.text = $"Time remaining: {(int)minutes}:{(int)seconds}";
        }
        //days.text = $"Days: {numberOfDays}";
    }
}
