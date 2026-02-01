using UnityEngine;
using TMPro;
public class ObservationNotesScript : MonoBehaviour
{
    public TextMeshProUGUI observationNotesText;
    public string[] bulletPoints;
    public bool[] bulletPointsDisplayed;
    public Dialogue3 dialogue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        observationNotesText.text = string.Empty;
        bulletPointsDisplayed = new bool[bulletPoints.Length];
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogue.clicked)
        {
            if (bulletPointsDisplayed[dialogue.index] == false)
            {
                observationNotesText.text += bulletPoints[dialogue.index];
                bulletPointsDisplayed[dialogue.index] = true;
            }
        }
    }
}
