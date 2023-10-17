using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxPlayer : MonoBehaviour
{

    public static bool death;
    public static bool touched = false;
    void OnTriggerEnter2D (Collider2D hitInfo)
	{
        Damage damage = hitInfo.GetComponent<Damage>();
		if (damage != null)
        {
            
            death = true;
            touched = true;
           
            
           
        }
        else 
        {
            touched = false;
        }

    }
}
