using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{

    public GameObject Door;
    public playermovement pm;
    public GameObject[] player;

    
    public GameObject Checkpoint;
    
    public Transform playerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        
        if (playermovement.interact == true)
        {
            if (other.tag == "Player")
            {
              StartCoroutine (Teleport ());
            }
        }
        //&& Input.GetButtonDown("Interact")
        
    }

    IEnumerator Teleport()
    {
        //yield return new WaitForSeconds (1);
        player = GameObject.FindGameObjectsWithTag("Player");
        foreach(GameObject p in player)
            p.transform.position = new Vector2 (Door.transform.position.x, Door.transform.position.y -0.51f);
       // player.transform.position = new Vector2 (Door.transform.position.x, Door.transform.position.y -0.51f);
        
        Checkpoint.transform.position = new Vector2 (Door.transform.position.x, Door.transform.position.y -0.51f);
        yield return null;
    }
}
