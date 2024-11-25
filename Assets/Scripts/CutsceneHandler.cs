using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CutsceneHandler : MonoBehaviour
{
    public Animator animator;
    private int scene = 1;

    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (scene == 1)
        {
            text1.SetActive(true);
            text2.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(false);
        }

        else if (scene == 2)
        {
            text1.SetActive(false);
            text2.SetActive(true);
            text3.SetActive(false);
            text4.SetActive(false);
            animator.SetBool("part2", true);
        }

        else if (scene == 3)
        {
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(true);
            text4.SetActive(false);
            animator.SetBool("part3", true);
        }

        else if (scene == 4)
        {
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(true);
            animator.SetBool("part4", true);
        }

        if (Input.GetButtonDown("VERDE0"))
            scene++;

        if (scene == 5)
        {
            SceneManager.LoadScene("TopDown(Game)");
        }
    }
}

