using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmarioAnimation : MonoBehaviour
{
    Animator animator;
    private bool playerInside;
    void Start()
    {
        animator = GetComponent<Animator>();
        playerInside = false;
        animator.SetBool("open", false);
    }

    void Update()
    {
        if (Input.GetButtonDown("VERMELHO0") && playerInside)
        {
            animator.SetBool("open", true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerInside = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerInside = false;
        animator.SetBool("open", false);
    }
}
