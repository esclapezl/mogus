using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{

    public static GameMaster gm ;
    
    public Animator animator;

    
    void OnStart ()
    {
        RespawnPlayer ();
    }
    void Awake () 
    {
        if (gm == null) 
        {
            gm = this;
        }

    }
    public int spawnDelay = 1;
    public Transform playerPrefab;
    public Transform spawnPoint;
    public Transform spawnPrefab;
    

    public static bool death = false;
    public static bool wall = false;
    public static bool speardestroy = false;
    

    


    

    

    public IEnumerator RespawnPlayer ()
    {
        yield return null;
        
        yield return new WaitForSeconds (spawnDelay);
        Instantiate (playerPrefab, spawnPoint.position, spawnPoint.rotation);
        animator.SetBool("isjumping", false);
        speardestroy = false;
        
        Weapon.veriftir = 0;
        death = false;

        
    }
    public static void KillPlayer (playerstats playerstats)
    {
        
        Instantiate (gm.spawnPrefab, playerstats.transform.position, playerstats.transform.rotation);
        Destroy (playerstats.gameObject);
        
        wall = true;
        death = true;
        speardestroy = true;
        
        gm.StartCoroutine(gm.RespawnPlayer());
        wall = false;        
        

    }

    public static void RestartPlayer (playerstats playerstats)
    {
        Instantiate (gm.spawnPrefab, playerstats.transform.position, playerstats.transform.rotation);
        Destroy (playerstats.gameObject);
        death = true;
        wall = true;

        
        gm.StartCoroutine(gm.Restart());
        //wall = false;        
        
        

    }

    public IEnumerator Restart ()
    {
        death = false;
        yield return new WaitForSeconds (0.1f);
        Instantiate (playerPrefab, spawnPoint.position, spawnPoint.rotation);
        animator.SetBool("isjumping", false);
        death = false;
        Weapon.veriftir = 0;
        

        
    }

    public static void resetblock ()
    {
        
    }

    
    
    
}
