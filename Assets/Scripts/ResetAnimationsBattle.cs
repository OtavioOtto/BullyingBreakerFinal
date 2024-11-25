using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAnimationsBattle : MonoBehaviour
{
    public GameObject UI;
    private AnimateBattles animator;
    private GameController gameController;

    private void Start()
    {
        animator = UI.GetComponent<AnimateBattles>();
        gameController = UI.GetComponent<GameController>();
    }

    public void ReturnToIdle() 
    {
        animator.ReturnToIdle();
    }

    public void DoActions(string action) 
    {
        if (action == "attack")
            gameController.AttackButton(1);

        else if (action == "strongerAttack")
            gameController.AttackButton(2);

        else if (action == "empathy")
            gameController.EmpathyButton(1);

        else if (action == "strongerEmpathy")
            gameController.EmpathyButton(2);
    }
}
