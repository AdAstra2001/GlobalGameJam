using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 4f;
    private Vector3 targetPosition;
    private static Vector3 basePosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        basePosition = transform.position;
        targetPosition = transform.position;
    }
    private void OnMouseDown()
    {
        targetPosition = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position != targetPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }

    }
}
