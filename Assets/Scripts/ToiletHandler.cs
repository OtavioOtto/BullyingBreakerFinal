using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletHandler : MonoBehaviour
{
    Animator animator;
    private bool playerInside;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("playerIsInside", false);
        animator.SetBool("flush", false);
        playerInside = false;
    }

    private void Update()
    {
        if (Input.GetButtonDown("VERDE0") && playerInside)
        {
            animator.SetBool("flush", true);
        }
    }

    public void ResetFlush() {

        animator.SetBool("flush", false);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetBool("playerIsInside", true);
        playerInside = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("playerIsInside", false);
        animator.SetBool("flush", false);
    }
}
