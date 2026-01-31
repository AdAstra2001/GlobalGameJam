using UnityEngine;
using UnityEngine.EventSystems;

public class PanelClicker : MonoBehaviour, IPointerClickHandler
{
    public Dialogue dialogue;
    public int index;
    public bool hasRun;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hasRun = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (hasRun)
        {
            return;
        }
        dialogue.StartDialogue(index);
        hasRun = true;
    }
}
