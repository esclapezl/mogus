using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bathitbox : MonoBehaviour
{
    
    public bathitbox b;
    public Transform spawnPrefab;
    public GameObject bat;
    public static bool batdead;

    

    void OnTriggerEnter2D (Collider2D hitInfo)
	{
        
        Bullet bullet = hitInfo.GetComponent<Bullet>();
		if (bullet != null)
		{
            batdead = true;
            Destroy(bat);
            Instantiate (b.spawnPrefab, gameObject.transform.position, gameObject.transform.rotation);
		}
    }
    
}
