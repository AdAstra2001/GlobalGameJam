using UnityEngine;

public class WinCheck : MonoBehaviour
{
    public string correctMask; //Write the correct mask in the insepctor when creating the characters.
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(correctMask)) //checks for the correct one. 
        {
            Debug.Log("Correctmask");
            TransitionScreen.instance.FaidInUI();
        }
        else
        {
            Debug.Log("Wrongmask");
        }
    }
}
