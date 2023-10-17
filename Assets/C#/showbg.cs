using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showbg : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bg;
    
	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Player") && !other.isTrigger)
		{
			bg.SetActive(true);
		}
	}
  
}
