using UnityEngine;
using UnityEngine.EventSystems;

public class PanelClicker2 : MonoBehaviour, IPointerClickHandler
{
    public Dialogue3 dialogue;
    public static PanelClicker2 Instance;
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
        Debug.Log("Starting Dialogue");
        dialogue.StartDialogue(index);
    }
}
