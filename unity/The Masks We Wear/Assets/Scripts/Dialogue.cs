using System.Collections;
using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{

    public TextMeshProUGUI text;
    public string[] sentences;
    public float typingSpeed;
    private int index;
    public GameObject dialogueBox;
    public MovePerson person;
    private bool clicked = false;
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
        this.index = index;
        //if (clicked)
        //{
        //    return;
        //}
        if (person.reachedTarget)
        {
            clicked = true;
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
        Debug.Log("Finished Typing");
    }
}
