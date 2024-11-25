using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiaCollider : MonoBehaviour
{
    Animator animator;
    private bool playerInside;
    void Start()
    {
        animator = GetComponent<Animator>();
        playerInside = false;
        animator.SetBool("fill", false);
    }

    void Update()
    {
        if (Input.GetButtonDown("VERMELHO0") && playerInside) {

            animator.SetBool("fill", true);
        
        }
    }

    public void FillComplete() {

        animator.SetBool("fill", false);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerInside = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerInside = false;
    }
}
