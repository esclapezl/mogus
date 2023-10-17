using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spears : MonoBehaviour
{

    public float speed = 20f;
    public GameObject spear1;
    public GameObject spear2;
    public GameObject spear3;

    public Transform firePoint;
	
	public static int veriftir = 0; // verifie si la lance est plantée


    public bool spear1throw = false;
    public bool spear2throw = false;
    public bool spear3throw = false;






	public Animator animator;
    // Start is called before the first frame update
    public int lancetiree = 0;
    public bool plantee = false;
    void Start()
    {
        
    }

    // Update is called once per frame
     void Update()
    {
		
        if (Input.GetButtonDown("Fire2"))
        {
            if (plantee == false)
            {
                if (lancetiree == 0)
                {
                    Shoot1();
                    spear1throw = true;
                    lancetiree++;
                }
                else if (lancetiree == 1)
                {
                   if (spear1throw == true)
                   {
                        Shoot2();
                        spear2throw = true;
                        
                   }
                   else if (spear2throw == true)  
                   {
                        Shoot1();
                        spear1throw = true;
                      
                   }    
                   else if (spear3throw == true)  
                   {
                        Shoot1();
                        spear1throw = true;
                        
                   }                
                

                }
                else if (lancetiree == 2)
                {
                    if (spear1throw == false)
                    {
                        Shoot1();
                        spear1throw = true;
                        
                    
                    }
                    else if (spear2throw == false)
                    {
                        Shoot2();
                        spear2throw = true;
                    }
                    else if (spear3throw == false)
                    {
                        Shoot3();
                        spear3throw = true;
                    }
                    lancetiree++;
            
                }
                else if (lancetiree == 3)
                {
                    Destroy(gameObject);
                    Shoot1();

                }
                

			    animator.SetTrigger("throw");
			
            }
			
		
			

		}
	
		
    }


	void Shoot1 ()
	{
		//shoot logic
		Instantiate(spear1, firePoint.position, firePoint.rotation);
	
	}
    void Shoot2 ()
	{
		//shoot logic
		Instantiate(spear2, firePoint.position, firePoint.rotation);
	
	}
    void Shoot3 ()
	{
		//shoot logic
		Instantiate(spear3, firePoint.position, firePoint.rotation);
	
	}
}
