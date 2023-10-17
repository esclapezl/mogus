using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerstats : MonoBehaviour
{
    public class PlayerStats
    {
      public bool Alive = true;
    }

    

    public PlayerStats playerStats = new PlayerStats ();


   
    
    

     void Start ()
  {
      
  }
    //void OnTriggerEnter2D (Collider2D hitInfo)
	//{
        
	//	if (HitboxPlayer.touched == true)
      //  {
           // HitboxPlayer.touched = false;
           // DamagePlayer ();
            
       // }
    //}
 

    

    

    public void DamagePlayer ()
    {
        playerStats.Alive = false;
        if (playerStats.Alive == false)
        {
            GameMaster.KillPlayer(this);
         
            
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Restart"))
        {
            GameMaster.RestartPlayer(this);
        }

        if (HitboxPlayer.touched == true)
        {
            HitboxPlayer.touched = false;
            GameMaster.KillPlayer(this);
        }
    }
  
 
}
