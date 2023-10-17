using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{

   // public Text nameText;
    //public Text dialogueText;
    public TextMeshProUGUI nt;
    public TextMeshProUGUI dl;

    public Animator animator;
    public Animator nameanimator;
    public Animator dialogueanimator;
    public Queue<string> sentences;
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
       animator.SetBool("IsOpen", true);
       nameanimator.SetBool("text", true);
       dialogueanimator.SetBool("onoff", true);
       //nameText.text = dialogue.name;
        nt.text = dialogue.name;

        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence ()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
       // dialogueText.text = sentence;
        dl.text = sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dl.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dl.text += letter;
            //yield return null; //pr 1 frame
            yield return new WaitForSeconds(0.03f);
        }
    }

    public void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        nameanimator.SetBool("text", false);
        dialogueanimator.SetBool("onoff", false);
    }

}
