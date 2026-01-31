using UnityEngine;

public class SetActive : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Person;
    public GameObject Mask1;
    void Start()
    {
        Person.SetActive(true);
        Mask1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Person.transform.position.y < -6)
        {
            Person.SetActive(false);
            Mask1.SetActive(false);
        }
    }
}
