using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomb : MonoBehaviour
{
    public Animator animator;
    
    void Update()
    {
        if (bathitbox.batdead == true)
        {
            animator.SetBool("batdead", true);
        }
        
    }
}
