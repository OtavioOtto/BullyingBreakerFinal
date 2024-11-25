using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationRuaController : MonoBehaviour
{
    public Animator[] carAnimators;

    private void Start()
    {
        carAnimators[0].SetBool("animate", true);
    }
    public void StartNextCarAnimation(int index)
    {
        if (index + 1 < carAnimators.Length)
        {
            carAnimators[index + 1].SetBool("animate", true);
        }
        else
        {
            RestartFirstCarAnimation();
        }
    }
    private void RestartFirstCarAnimation()
    {
        StartCoroutine(WaitToAnimate());
    }

    public void EndAnimation(int index) 
    {

        carAnimators[index].SetBool("animate", false);
    
    }
    private IEnumerator WaitToAnimate() 
    {
        yield return new WaitForSeconds(2.5f);
        carAnimators[0].SetBool("animate", true);
    }
}
