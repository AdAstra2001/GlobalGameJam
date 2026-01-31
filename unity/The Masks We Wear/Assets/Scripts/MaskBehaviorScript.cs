using Unity.VisualScripting;
using UnityEngine;

public class MaskMove : MonoBehaviour
{
    public float moveSpeed = 4f;
    private Vector3 targetPosition;
    private static Vector3 basePosition;

    private bool shouldMove = false;
    public BoxCollider boxCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        basePosition = transform.position;
        targetPosition = transform.position;
    }
    private void OnMouseDown()
    { //If another cube was already chosen, do nothing
        if (DisableClick.Instance.maskChosen)
        {
            return;
        }
        // Lock all other masks
        DisableClick.Instance.maskChosen = true;

        //Disable all mask colliders to prevent further clicking
        MaskMove[] masks = FindObjectsByType<MaskMove>(FindObjectsSortMode.None);
        foreach (MaskMove mask in masks)
        {
            mask.boxCollider.enabled = false;
        }
        
        targetPosition = new Vector3((float)-3.11, (float)0.17, 0);//Edit this to the position of the player head
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position != targetPosition)
        {
            this.boxCollider.enabled = true;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
        
    }

  
}
