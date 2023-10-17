using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	
	public float speed = 20f;
	public Rigidbody2D rb;
	public int damage = 1;
	
	public int shootCounter = 0; //
	public Weapon weapon;
	int getscore=Weapon.veriftir;
	public Animator animator;
	public GameObject particles;

	
	
	
	
	public Transform spawnParticles;
	
	public int health = 1;
	
    // Start is called before the first frame update
    void Start()
    {
		//gameObject.GetComponent<Collider2D>().enabled = false;
        rb.velocity = transform.right * speed;
    }
	
	void OnTriggerEnter2D (Collider2D hitInfo)
	{
		

		Enemy enemy = hitInfo.GetComponent<Enemy>();
		if (enemy != null)
		{
			enemy.TakeDamage(damage);
			Destroy(gameObject);
			Weapon.veriftir=0;
			
			Instantiate(particles, spawnParticles.transform.position, spawnParticles.transform.rotation);
			
			
		}
		
		wall wall = hitInfo.GetComponent<wall>();
		if (wall != null)
		{
			
			
			Weapon.veriftir=0;
			
			rb = GetComponent<Rigidbody2D>();
       		 //This locks the RigidBody so that it does not move or rotate in the Z axis.
       		rb.constraints = RigidbodyConstraints2D.FreezeAll;
			   Instantiate(particles, spawnParticles.transform.position, spawnParticles.transform.rotation);
			//gameObject.GetComponent<Collider2D>().enabled = true;
		}
		
		Bullet bullet = hitInfo.GetComponent<Bullet>();
		if (bullet != null)
		{
			Destroy(gameObject);
			Weapon.veriftir=0;
			
			Instantiate(particles, spawnParticles.transform.position, spawnParticles.transform.rotation);
		}

		border border = hitInfo.GetComponent<border>();
		if (border != null)
		{
			Destroy(gameObject);
			Weapon.veriftir=0;
			
			Instantiate(particles, spawnParticles.transform.position, spawnParticles.transform.rotation);
		}
		border2 border2 = hitInfo.GetComponent<border2>();
		if (border2 != null)
		{
			Destroy(gameObject);
			Weapon.veriftir=0;
			
			Instantiate(particles, spawnParticles.transform.position, spawnParticles.transform.rotation);
		}
			antiblock antiblock = hitInfo.GetComponent<antiblock>();
		if (antiblock != null)
		{
			Destroy(gameObject);
			Weapon.veriftir=0;
			
			Instantiate(particles, spawnParticles.transform.position, spawnParticles.transform.rotation);
		}
		
		bathitbox bat = hitInfo.GetComponent<bathitbox>();
		if (bat != null)
		{
			
			Destroy(gameObject);
			Weapon.veriftir=0;
			Instantiate(particles, spawnParticles.transform.position, spawnParticles.transform.rotation);
			
			
		}

		howl howl = hitInfo.GetComponent<howl>();
		if (howl != null)
		{
			
			Destroy(gameObject);
			Weapon.veriftir=0;
			Instantiate(particles, spawnParticles.transform.position, spawnParticles.transform.rotation);
			
			
		}
		
		
	}
	

	void Update ()
	{
		if (hitboxwall.playerinwall == false)
		{		
			if (Input.GetButtonDown("Fire1") && Weapon.veriftir == 0) //la variable score est mise a jour avant que la condition puisse verifier, à corriger
			{
				shootCounter += 1;
			
				if (shootCounter == 3)
				{
					Destroy(gameObject);
				}
			
			}
			if (shootCounter == 1)
			{
				animator.SetInteger("etat", 1);
			}
			if (shootCounter == 2)
			{
				animator.SetInteger("etat", 2);
			}

			
		}

		if (GameMaster.death == true || Input.GetButtonDown("RestartSpears") || Input.GetButtonDown("Restart"))
		{
			{
				Destroy (gameObject);
				Instantiate(particles, spawnParticles.transform.position, spawnParticles.transform.rotation);
			}
			if (GameMaster.speardestroy == true)
			{
				Destroy (gameObject);
				Instantiate(particles, spawnParticles.transform.position, spawnParticles.transform.rotation);
			}
		}
	}
}
	
