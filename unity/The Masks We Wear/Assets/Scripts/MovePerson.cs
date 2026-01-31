using UnityEngine;

public class MovePerson : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 6f;
    private Vector3 targetPosition;
    private static Vector3 basePosition;
    public bool reachedTarget = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        basePosition = transform.position;
        targetPosition = transform.position;
        targetPosition = new Vector3(-5, 0, 0);//Edit this to the position of the player head
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != targetPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
        else
        {
            reachedTarget = true;
        }

    }
}
