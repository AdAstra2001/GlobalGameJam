using TMPro;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public TMP_Text timerText;
    public float minutes;
    //public TMP_Text days;
    public int numberOfDays;
    public float seconds;
    //public DayNightScript dayNightScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        minutes = 0;
        seconds = 60;
        numberOfDays = 0;
        //UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        //calls the timer operation 
        //Invoke("timerOperation", 1);
        if (seconds <= 0)
        {
            //minutes--;
            seconds = 60;
        }
        //if (minutes < 0)
        //{
            //really we would give them a penalty or something here
        //    seconds = 59;
        //}
        seconds -= Time.deltaTime;
        UpdateUI();

    }

    /// <summary>
    /// causes the timer to count down
    /// </summary>
    /*private void timerOperation()
    {

            if (seconds <= 0)
            {
                minutes--;
                seconds = 59;
            }
            seconds -= Time.deltaTime;
            UpdateUI();
    }*/

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
