using TMPro;
using System.Collections;
using UnityEngine;

public class Dialogue3 : MonoBehaviour
{

    public TextMeshProUGUI text;
    public string[] sentences;
    public float typingSpeed;
    public int index;
    public GameObject dialogueBox;
    public MovePerson person;
    public bool clicked = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text.text = string.Empty;


        //StartDialogue();
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void StartDialogue(int index)
    {
       StopAllCoroutines();
        this.index = index;
        text.text = string.Empty;
        if (person.reachedTarget)
        {
            index = 0;
            dialogueBox.SetActive(true);
            //doesn't run a method all at one. Does one step, takes a break, then continues to the next step
            StartCoroutine(TypeLine());
        }
    }

    void NextLine()
    {

    }

    //IEnumerator is used to iterate through data one thing at a time
    public IEnumerator TypeLine()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            text.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        clicked = true;
        PanelClicker2.Instance.hasRun = true;
        Debug.Log("Finished Typing");
    }
}