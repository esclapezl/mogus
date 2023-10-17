using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour 
{
	public Transform LaunchOffset;
	
	public CharacterController2D controller;
	public Animator animator;
	public ParticleSystem dust;

	public static bool interact;



	
	
	
	
	public float runSpeed = 40f;
	
	float horizontalMove = 0f;
	bool jump = false;

    // Update is called once per frame

	void OnStart ()
	{
		gameObject.tag = "Player";
	}
    void Update() {
        
      horizontalMove = Input.GetAxisRaw("Horizontal")*runSpeed;
	 

	  animator.SetFloat("speed", Mathf.Abs(horizontalMove));
	  
	  if (Input.GetButtonDown("Jump")){
		  jump = true;
		  //animator.SetBool("isjumping", true);
	  }
		if (Input.GetButtonDown("Interact")){
			interact = true;
		}
		else if(Input.GetButtonUp("Interact"))
		{
			interact = false;
		}

    }
	
	void FixedUpdate ()
	{
		//move character
		controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
		jump = false;
		
	
	}
	
	public void OnLanding ()
	{
		//animator.SetBool("isjumping", false);

	
	}
	void CreateDust(){

		dust.Play();
	}

	
}
