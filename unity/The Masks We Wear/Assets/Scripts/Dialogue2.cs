using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.Rendering;

public class Dialogue2 : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private int index;
    public string[] Button1;
    public string[] Button2;
    public string[] Button3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    public void ChooseOption1()
    {
        SwitchDialogue(Button1);
    }
    public void ChooseOption2()
    {
        SwitchDialogue(Button2);
    }
    public void ChooseOption3()
    {
        SwitchDialogue(Button3);
    }
    void SwitchDialogue(string[] newLines)
    {
        StopAllCoroutines();
        textComponent.text = string.Empty;
        lines = newLines;
        StartDialogue();
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach(char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
