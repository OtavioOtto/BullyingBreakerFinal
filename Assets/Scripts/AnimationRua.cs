using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationRua : MonoBehaviour
{
    private AnimationRuaController animationController;
    public int carIndex;

    void Start()
    {
        animationController = GetComponentInParent<AnimationRuaController>();
    }

    public void TriggerNextCarAnimation()
    {
        if (animationController != null)
        {
            animationController.StartNextCarAnimation(carIndex);
        }
    }

    public void EndAnimation() 
    {

        if (animationController != null)
        {
            animationController.EndAnimation(carIndex);
        }

    }
}
