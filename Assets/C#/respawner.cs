using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawner : MonoBehaviour
{
    public GameObject blockPrefab;
    public respawner rp;

    private bool etatrespawn;
    

    
    
    
    public IEnumerator wait()
    {
        yield return new WaitForSeconds (1);
    }
    
    void Awake () 
    {
        if (rp == null) 
        {
            rp = this;
        }

    }
    void Update()
    {
        if (Input.GetButtonDown("Restart"))
        {   
            Instantiate (blockPrefab, gameObject.transform.position, gameObject.transform.rotation);
            
        }

        if (GameMaster.death == true)
        {
            rp.StartCoroutine(rp.wait());
            Instantiate (blockPrefab, gameObject.transform.position, gameObject.transform.rotation);
            //etatrespawn = true;

        }

        if (etatrespawn == true)
        {
            //etatrespawn = false;
            
            
            
        }


    }
}
