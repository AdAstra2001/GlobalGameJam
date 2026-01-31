using UnityEngine;

public class MaskScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Transform thisTF;//variable for transformation of object
    void Start()
    {
        thisTF = GetComponent<Transform>();
    }

    private void OnMouseEnter()
    {
        Vector3 scaleUp = new Vector3(thisTF.localScale.x + 0.2f, thisTF.localScale.y + 0.2f, thisTF.localScale.z);
        thisTF.localScale = scaleUp;
    }

    private void OnMouseExit()
    {
        Vector3 scaleDown = new Vector3(thisTF.localScale.x - 0.2f, thisTF.localScale.y - 0.2f, thisTF.localScale.z);
        thisTF.localScale = scaleDown;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
