using UnityEngine;

public class ToggleIntake : MonoBehaviour
{
    public GameObject form;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ToggleForm()
    {
        if(form.activeSelf)
        {
            form.SetActive(false);
        }
        else
        {
            form.SetActive(true);
        }
    }
}
