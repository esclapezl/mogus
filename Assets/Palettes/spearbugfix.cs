using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spearbugfix : MonoBehaviour
{
    public GameObject particles;
    public GameObject bull;
    public Transform spawnParticles;
    void OnTriggerEnter2D (Collider2D hitInfo)
	{
		
		wall wall = hitInfo.GetComponent<wall>();
		if (wall != null)
		{
			
			Destroy(bull);
			Instantiate(particles, spawnParticles.transform.position, spawnParticles.transform.rotation);
			
			
		}
    }
}
