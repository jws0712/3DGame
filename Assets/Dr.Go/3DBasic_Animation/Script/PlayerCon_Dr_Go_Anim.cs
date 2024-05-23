using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon_Dr_Go_Anim : MonoBehaviour
{

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            animator.SetFloat("moveSpeed", 0.0f);
            //animator.Play("Idle");
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetFloat("moveSpeed", 5.0f);
            //animator.Play("RUN00_F");
        }
    }
}
