using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitboxwall : MonoBehaviour
{
    public static bool playerinwall = false;
     void OnTriggerStay2D (Collider2D hitInfo)
	{
		
		wall wall = hitInfo.GetComponent<wall>();
		if (wall != null)
		{
            playerinwall = true;
		}
        else 
        {
           playerinwall = false;
        }
    }
}
