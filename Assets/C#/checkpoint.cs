using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{

    public GameObject Cp;
    public GameObject NewCheckpoint;
   void OnTriggerStay2D (Collider2D hitInfo)
	{
        playermovement player = hitInfo.GetComponent<playermovement>();
        if (player != null)
		{
            Cp.transform.position = new Vector2 (NewCheckpoint.transform.position.x, NewCheckpoint.transform.position.y -0.51f);
         
		}
       
    }
}
