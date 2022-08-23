using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public Animator animator;

    public Text nameText;
    public Text dialogueText;

    private Queue<string> dialogueSentence;
   
    void Start()
    {
        dialogueSentence = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("isOpen", true);
        nameText.text = dialogue.name;

        dialogueSentence.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            dialogueSentence.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        
        if(dialogueSentence.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = dialogueSentence.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";

        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(.01f);
        }
    }
    public void EndDialogue()
    {
        animator.SetBool("isOpen", false);
    }
    void Update()
    {
        
    }
}
