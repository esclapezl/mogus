using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    
    DialogueManager dm;
    DialogueTrigger td;


    void OnTriggerEnter2D (Collider2D hitInfo)
	{

		dm = GameObject.FindGameObjectWithTag("dm").GetComponent<DialogueManager>();
        td = gameObject.GetComponent<DialogueTrigger>();
		playermovement player = hitInfo.GetComponent<playermovement>();
		if (player != null)
		{

            
			//Debug.Log("activate");
            td.TriggerDialogue();
			dm.DisplayNextSentence();
		}
    }

    void OnTriggerExit2D (Collider2D hitInfo)
	{
        dm = GameObject.FindGameObjectWithTag("dm").GetComponent<DialogueManager>();
        playermovement player = hitInfo.GetComponent<playermovement>();
		if (player != null)
		{
           dm.EndDialogue();
		}

    }
}
