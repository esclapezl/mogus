using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E : MonoBehaviour
{

    public Animator animator;
     void OnTriggerEnter2D (Collider2D hitInfo)
	{
        playermovement player = hitInfo.GetComponent<playermovement>();
        if (player != null)
		{

         animator.SetBool("Eon", true);
		}
       
    }

    void OnTriggerExit2D (Collider2D hitInfo)
	{
        playermovement player = hitInfo.GetComponent<playermovement>();
        if (player != null)
		{

         animator.SetBool("Eon", false);
		}
    }
}

