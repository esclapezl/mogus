using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxblockfront : MonoBehaviour
{
   public static bool nothingback;
   void OnTriggerEnter2D (Collider2D hitInfo)
	{
        Enemy enemy = hitInfo.GetComponent<Enemy>();
		if (enemy != null)
        {
            nothingback = false; 
        }
        else 
        {
            nothingback = true;
        }

    }
}
