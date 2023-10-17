using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
	public Transform firePoint;
	public GameObject bulletPrefab;
	public GameObject bulletPrefab2;

	public static int veriftir = 0; // verifie si la lance est plantée
	public static int shootcounterpublic = 0;
	public Animator animator;
	
		

    // Update is called once per frame


     void Update()
    {
		if (Input.GetButtonDown("Fire1"))
		
		{	
			
			animator.SetTrigger("throw");
			animator.SetBool("isjumping", false);
       	 	if (hitboxwall.playerinwall == false)
       		{
				
           		if (veriftir == 0)
           		{
               		if (hitboxblock.playerinblock == false)
					{
						Shoot();
					}
					else if (hitboxblock.playerinblock == true && HitBoxblockfront.nothingback == false)
					{
						Shoot2();
					}
					else if (hitboxblock.playerinblock == true && HitBoxblockfront.nothingback == true)
					{
						Shoot();
					}
				   	animator.SetTrigger("throw");
					animator.SetBool("isjumping", false);
					veriftir = 1;
					shootcounterpublic++;
				
			
            	}	
			}

		}
	
		
    }


	void Shoot ()
	{
		//shoot logic
		Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
		
	}

	void Shoot2 ()
	{
		//shoot logic
		Instantiate(bulletPrefab2, firePoint.position, firePoint.rotation);
		
	
	}
}
