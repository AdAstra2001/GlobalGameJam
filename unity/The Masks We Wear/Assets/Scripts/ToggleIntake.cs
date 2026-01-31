using UnityEngine;

public class ToggleIntake : MonoBehaviour
{
    public GameObject intakeForm;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ToggleIntakeForm()
    {
        if(intakeForm.activeSelf)
        {
            intakeForm.SetActive(false);
        }
        else
        {
            intakeForm.SetActive(true);
        }
    }
}
