using UnityEngine;

public class WinCheck : MonoBehaviour
{
    public string correctMask; //Write the correct mask in the insepctor when creating the characters.
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(correctMask)) //checks for the correct one. 
        {
            Debug.Log("Correctmask");
            TransitionScreen.instance.ShowResult(TransitionScreen.ResultType.Correct);
        }
        else
        {
            Debug.Log("Wrongmask");
            TransitionScreen.instance.ShowResult(TransitionScreen.ResultType.Wrong);
        }
    }
    private void Update()
    {
        if (TimerScript.instance.seconds <= 0)
        {
            second
            TransitionScreen.instance.ShowResult(TransitionScreen.ResultType.TimeOut);
        }
    }
}
