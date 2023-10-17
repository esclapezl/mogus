using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitboxblock : MonoBehaviour
{

    public GameObject Fp;
    public GameObject Ref;
    public GameObject Player;

    public static bool playerinblock = false;
   void OnTriggerStay2D (Collider2D hitInfo)
	{
        
		
		Enemy enemy = hitInfo.GetComponent<Enemy>();
		if (enemy != null)
		{
            Fp.transform.position = new Vector3(Player.transform.position.x, Fp.transform.position.y, 0);
            playerinblock = true;
		}
        else 
        {
           Fp.transform.position = new Vector3(Ref.transform.position.x, Ref.transform.position.y, 0);
           playerinblock = false;
        }
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
	{
        
		
		Enemy enemy = hitInfo.GetComponent<Enemy>();
		if (enemy != null)
		{
            Fp.transform.position = new Vector3(Player.transform.position.x, Fp.transform.position.y, 0);
            playerinblock = true;
		}
        else 
        {
           Fp.transform.position = new Vector3(Ref.transform.position.x, Ref.transform.position.y, 0);
           playerinblock = false;
        }
    }

    
}
