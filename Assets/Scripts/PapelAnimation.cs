using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapelAnimation : MonoBehaviour
{
    Animator animator;
    public GameObject ui;
    public bool closing;

    public void AtivarDesativarUI() {

        if (!ui.activeSelf)
            ui.SetActive(true);
        else
            ui.SetActive(false);
    }

    public void Animate() {
        if(animator == null)
            animator = GetComponent<Animator>();
        if (!closing)
        {
            this.gameObject.SetActive(true);
            animator.SetBool("open", true);
        }

        else if(closing)
        {
            animator.SetBool("open", false);
        }
    }

    public void AtivarDesativarTexto()
    {

        if (!transform.GetChild(0).gameObject.activeSelf)
            transform.GetChild(0).gameObject.SetActive(true);
        else
            transform.GetChild(0).gameObject.SetActive(false);

    }
}
