using UnityEngine;

public class SetActive : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Person;
    public GameObject Mask1;
    public GameObject Mask2;
    public GameObject Mask3;
    public GameObject Mask4;
    void Start()
    {
        Person.SetActive(true);
        Mask1.SetActive(true);
        Mask2.SetActive(true);
        Mask3.SetActive(true);
        Mask4.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Person.transform.position.y < -10)
        {
            Person.SetActive(false);
            Mask1.SetActive(false);
            Mask2.SetActive(false);
            Mask3.SetActive(false);
            Mask4.SetActive(false);
        }
    }
}
