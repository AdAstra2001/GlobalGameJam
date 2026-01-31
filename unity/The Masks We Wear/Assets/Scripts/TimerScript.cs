using TMPro;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public TMP_Text timerText;
    public float minutes;
    //public TMP_Text days;
    public int numberOfDays;
    public float seconds;
    public DayNightScript dayNightScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        minutes = 1;
        seconds = 0;
        numberOfDays = 0;
        //UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        //calls the timer operation every 5 seconds
        Invoke("timerOperation", 1);
        
    }

    /// <summary>
    /// causes the timer to count down
    /// </summary>
    private void timerOperation()
    {
        if (dayNightScript.spawned == false)
        {

            if (seconds <= 0)
            {
                minutes--;
                seconds = 59;
            }
            seconds -= Time.deltaTime*(float)0.5;
            UpdateUI();
        }
    }

    /// <summary>
    /// updates the timer UI
    /// </summary>
    public void UpdateUI()
    {
        if (seconds == 0)
        {
            timerText.text = $"{(int)minutes}:00";
        }
        else if (seconds < 10)
        {
            timerText.text = $"{(int)minutes}:0{(int)seconds}";
        }
        else
        {
            timerText.text = $"{(int)minutes}:{(int)seconds}";
        }
        //days.text = $"Days: {numberOfDays}";
    }
}
