using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bat : MonoBehaviour
{
    public Animator animator;
   
    

    void OnTriggerEnter2D (Collider2D hitInfo)
	{
		playermovement player = hitInfo.GetComponent<playermovement>();
		if (player != null)
		{
            animator.SetBool("batrange", true);
		}
        
    }   

    void OnTriggerExit2D (Collider2D hitInfo)
	{
        playermovement player = hitInfo.GetComponent<playermovement>();
		if (player != null)
		{
            animator.SetBool("batrange", false);
		}

    }
    
}
