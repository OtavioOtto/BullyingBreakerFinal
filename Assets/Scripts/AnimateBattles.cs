using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateBattles : MonoBehaviour
{
    public Animator animatorEnemy1;
    public Animator animatorEnemy2;
    public Animator animatorEnemy3;
    public Animator animatorEnemy4;

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;

    public Animator animatorBoss1;
    public Animator animatorBoss2;
    public Animator animatorBoss3;

    public GameObject boss1;
    public GameObject boss2;
    public GameObject boss3;

    public GameController gameController;

    private void Start()
    {
        gameController = GetComponent<GameController>();
    }

    public void SetAnimations(string action)
    {
        if (enemy1.activeSelf) 
        {
            if (action == "attack" && gameController.currentTurnIndex == 0) 
            {
                animatorEnemy1.SetBool("jimmyAttack", true);
            }

            else if (action == "attack" && gameController.currentTurnIndex == 1)
            {
                animatorEnemy1.SetBool("vanessaAttack", true);
            }

            else if(action == "strongerAttack" && gameController.currentTurnIndex == 0)
            {
                animatorEnemy1.SetBool("jimmyStrongerAttack", true);
            }

            else if (action == "strongerAttack" && gameController.currentTurnIndex == 1)
            {
                animatorEnemy1.SetBool("vanessaStrongerAttack", true);
            }

            else if (action == "empathy" && gameController.currentTurnIndex == 0)
            {
                animatorEnemy1.SetBool("jimmyEmpathy", true);
            }

            else if (action == "empathy" && gameController.currentTurnIndex == 1)
            {
                animatorEnemy1.SetBool("vanessaEmpathy", true);
            }

            else if (action == "strongerEmpathy" && gameController.currentTurnIndex == 0)
            {
                animatorEnemy1.SetBool("jimmyStrongerEmpathy", true);
            }

            else if (action == "strongerEmpathy" && gameController.currentTurnIndex == 1)
            {
                animatorEnemy1.SetBool("vanessaStrongerEmpathy", true);
            }

            else if (action == "item" && gameController.currentTurnIndex == 0)
            {
                animatorEnemy1.SetBool("jimmyItem", true);
            }

            else if (action == "item" && gameController.currentTurnIndex == 1)
            {
                animatorEnemy1.SetBool("vanessaItem", true);
            }

            else if (action == "enemy")
            {
                animatorEnemy1.SetBool("enemyAttack", true);
            }
        }

        else if (enemy2.activeSelf)
        {
            if (action == "attack" && gameController.currentTurnIndex == 0)
            {
                animatorEnemy2.SetBool("jimmyAttack", true);
            }

            else if (action == "attack" && gameController.currentTurnIndex == 1)
            {
                animatorEnemy2.SetBool("vanessaAttack", true);
            }

            else if (action == "strongerAttack" && gameController.currentTurnIndex == 0)
            {
                animatorEnemy2.SetBool("jimmyStrongerAttack", true);
            }

            else if (action == "strongerAttack" && gameController.currentTurnIndex == 1)
            {
                animatorEnemy2.SetBool("vanessaStrongerAttack", true);
            }

            else if (action == "empathy" && gameController.currentTurnIndex == 0)
            {
                animatorEnemy2.SetBool("jimmyEmpathy", true);
            }

            else if (action == "empathy" && gameController.currentTurnIndex == 1)
            {
                animatorEnemy2.SetBool("vanessaEmpathy", true);
            }

            else if (action == "strongerEmpathy" && gameController.currentTurnIndex == 0)
            {
                animatorEnemy2.SetBool("jimmyStrongerEmpathy", true);
            }

            else if (action == "strongerEmpathy" && gameController.currentTurnIndex == 1)
            {
                animatorEnemy2.SetBool("vanessaStrongerEmpathy", true);
            }

            else if (action == "item" && gameController.currentTurnIndex == 0)
            {
                animatorEnemy2.SetBool("jimmyItem", true);
            }

            else if (action == "item" && gameController.currentTurnIndex == 1)
            {
                animatorEnemy2.SetBool("vanessaItem", true);
            }

            else if (action == "enemy")
            {
                animatorEnemy2.SetBool("enemyAttack", true);
            }
        }

        else if (enemy3.activeSelf)
        {
            if (action == "attack" && gameController.currentTurnIndex == 0)
            {
                animatorEnemy3.SetBool("jimmyAttack", true);
            }

            else if (action == "attack" && gameController.currentTurnIndex == 1)
            {
                animatorEnemy3.SetBool("vanessaAttack", true);
            }

            else if (action == "strongerAttack" && gameController.currentTurnIndex == 0)
            {
                animatorEnemy3.SetBool("jimmyStrongerAttack", true);
            }

            else if (action == "strongerAttack" && gameController.currentTurnIndex == 1)
            {
                animatorEnemy3.SetBool("vanessaStrongerAttack", true);
            }

            else if (action == "empathy" && gameController.currentTurnIndex == 0)
            {
                animatorEnemy3.SetBool("jimmyEmpathy", true);
            }

            else if (action == "empathy" && gameController.currentTurnIndex == 1)
            {
                animatorEnemy3.SetBool("vanessaEmpathy", true);
            }

            else if (action == "strongerEmpathy" && gameController.currentTurnIndex == 0)
            {
                animatorEnemy3.SetBool("jimmyStrongerEmpathy", true);
            }

            else if (action == "strongerEmpathy" && gameController.currentTurnIndex == 1)
            {
                animatorEnemy3.SetBool("vanessaStrongerEmpathy", true);
            }

            else if (action == "item" && gameController.currentTurnIndex == 0)
            {
                animatorEnemy3.SetBool("jimmyItem", true);
            }

            else if (action == "item" && gameController.currentTurnIndex == 1)
            {
                animatorEnemy3.SetBool("vanessaItem", true);
            }

            else if (action == "enemy")
            {
                animatorEnemy3.SetBool("enemyAttack", true);
            }
        }

        else if (enemy4.activeSelf)
        {
            if (action == "attack" && gameController.currentTurnIndex == 0)
            {
                animatorEnemy4.SetBool("jimmyAttack", true);
            }

            else if (action == "attack" && gameController.currentTurnIndex == 1)
            {
                animatorEnemy4.SetBool("vanessaAttack", true);
            }

            else if (action == "strongerAttack" && gameController.currentTurnIndex == 0)
            {
                animatorEnemy4.SetBool("jimmyStrongerAttack", true);
            }

            else if (action == "strongerAttack" && gameController.currentTurnIndex == 1)
            {
                animatorEnemy4.SetBool("vanessaStrongerAttack", true);
            }

            else if (action == "empathy" && gameController.currentTurnIndex == 0)
            {
                animatorEnemy4.SetBool("jimmyEmpathy", true);
            }

            else if (action == "empathy" && gameController.currentTurnIndex == 1)
            {
                animatorEnemy4.SetBool("vanessaEmpathy", true);
            }

            else if (action == "strongerEmpathy" && gameController.currentTurnIndex == 0)
            {
                animatorEnemy4.SetBool("jimmyStrongerEmpathy", true);
            }

            else if (action == "strongerEmpathy" && gameController.currentTurnIndex == 1)
            {
                animatorEnemy4.SetBool("vanessaStrongerEmpathy", true);
            }

            else if (action == "item" && gameController.currentTurnIndex == 0)
            {
                animatorEnemy4.SetBool("jimmyItem", true);
            }

            else if (action == "item" && gameController.currentTurnIndex == 1)
            {
                animatorEnemy4.SetBool("vanessaItem", true);
            }

            else if (action == "enemy")
            {
                animatorEnemy4.SetBool("enemyAttack", true);
            }
        }

        else if (boss1.activeSelf)
        {
            if (action == "attack" && gameController.currentTurnIndex == 0)
            {
                animatorBoss1.SetBool("jimmyAttack", true);
            }

            else if (action == "attack" && gameController.currentTurnIndex == 1)
            {
                animatorBoss1.SetBool("vanessaAttack", true);
            }

            else if (action == "strongerAttack" && gameController.currentTurnIndex == 0)
            {
                animatorBoss1.SetBool("jimmyStrongerAttack", true);
            }

            else if (action == "strongerAttack" && gameController.currentTurnIndex == 1)
            {
                animatorBoss1.SetBool("vanessaStrongerAttack", true);
            }

            else if (action == "empathy" && gameController.currentTurnIndex == 0)
            {
                animatorBoss1.SetBool("jimmyEmpathy", true);
            }

            else if (action == "empathy" && gameController.currentTurnIndex == 1)
            {
                animatorBoss1.SetBool("vanessaEmpathy", true);
            }

            else if (action == "strongerEmpathy" && gameController.currentTurnIndex == 0)
            {
                animatorBoss1.SetBool("jimmyStrongerEmpathy", true);
            }

            else if (action == "strongerEmpathy" && gameController.currentTurnIndex == 1)
            {
                animatorBoss1.SetBool("vanessaStrongerEmpathy", true);
            }

            else if (action == "item" && gameController.currentTurnIndex == 0)
            {
                animatorBoss1.SetBool("jimmyItem", true);
            }

            else if (action == "item" && gameController.currentTurnIndex == 1)
            {
                animatorBoss1.SetBool("vanessaItem", true);
            }

            else if (action == "enemy")
            {
                animatorBoss1.SetBool("enemyAttack", true);
            }
        }

        else if (boss2.activeSelf)
        {
            if (action == "attack" && gameController.currentTurnIndex == 0)
            {
                animatorBoss2.SetBool("jimmyAttack", true);
            }

            else if (action == "attack" && gameController.currentTurnIndex == 1)
            {
                animatorBoss2.SetBool("vanessaAttack", true);
            }

            else if (action == "strongerAttack" && gameController.currentTurnIndex == 0)
            {
                animatorBoss2.SetBool("jimmyStrongerAttack", true);
            }

            else if (action == "strongerAttack" && gameController.currentTurnIndex == 1)
            {
                animatorBoss2.SetBool("vanessaStrongerAttack", true);
            }

            else if (action == "empathy" && gameController.currentTurnIndex == 0)
            {
                animatorBoss2.SetBool("jimmyEmpathy", true);
            }

            else if (action == "empathy" && gameController.currentTurnIndex == 1)
            {
                animatorBoss2.SetBool("vanessaEmpathy", true);
            }

            else if (action == "strongerEmpathy" && gameController.currentTurnIndex == 0)
            {
                animatorBoss2.SetBool("jimmyStrongerEmpathy", true);
            }

            else if (action == "strongerEmpathy" && gameController.currentTurnIndex == 1)
            {
                animatorBoss2.SetBool("vanessaStrongerEmpathy", true);
            }

            else if (action == "item" && gameController.currentTurnIndex == 0)
            {
                animatorBoss2.SetBool("jimmyItem", true);
            }

            else if (action == "item" && gameController.currentTurnIndex == 1)
            {
                animatorBoss2.SetBool("vanessaItem", true);
            }

            else if (action == "enemy")
            {
                animatorBoss2.SetBool("enemyAttack", true);
            }
        }

        else if (boss3.activeSelf)
        {
            if (action == "attack" && gameController.currentTurnIndex == 0)
            {
                animatorBoss3.SetBool("jimmyAttack", true);
            }

            else if (action == "attack" && gameController.currentTurnIndex == 1)
            {
                animatorBoss3.SetBool("vanessaAttack", true);
            }

            else if (action == "strongerAttack" && gameController.currentTurnIndex == 0)
            {
                animatorBoss3.SetBool("jimmyStrongerAttack", true);
            }

            else if (action == "strongerAttack" && gameController.currentTurnIndex == 1)
            {
                animatorBoss3.SetBool("vanessaStrongerAttack", true);
            }

            else if (action == "empathy" && gameController.currentTurnIndex == 0)
            {
                animatorBoss3.SetBool("jimmyEmpathy", true);
            }

            else if (action == "empathy" && gameController.currentTurnIndex == 1)
            {
                animatorBoss3.SetBool("vanessaEmpathy", true);
            }

            else if (action == "strongerEmpathy" && gameController.currentTurnIndex == 0)
            {
                animatorBoss3.SetBool("jimmyStrongerEmpathy", true);
            }

            else if (action == "strongerEmpathy" && gameController.currentTurnIndex == 1)
            {
                animatorBoss3.SetBool("vanessaStrongerEmpathy", true);
            }

            else if (action == "item" && gameController.currentTurnIndex == 0)
            {
                animatorBoss3.SetBool("jimmyItem", true);
            }

            else if (action == "item" && gameController.currentTurnIndex == 1)
            {
                animatorBoss3.SetBool("vanessaItem", true);
            }

            else if (action == "enemy")
            {
                animatorBoss3.SetBool("enemyAttack", true);
            }
        }
    }

    public void ReturnToIdle() 
    {
        if (enemy1.activeSelf)
        {
            animatorEnemy1.SetBool("jimmyAttack", false);
            animatorEnemy1.SetBool("jimmyStrongerAttack", false);
            animatorEnemy1.SetBool("jimmyEmpathy", false);
            animatorEnemy1.SetBool("jimmyStrongerEmpathy", false);
            animatorEnemy1.SetBool("jimmyItem", false);
            animatorEnemy1.SetBool("vanessaAttack", false);
            animatorEnemy1.SetBool("vanessaStrongerAttack", false);
            animatorEnemy1.SetBool("vanessaEmpathy", false);
            animatorEnemy1.SetBool("vanessaStrongerEmpathy", false);
            animatorEnemy1.SetBool("vanessaItem", false);
            animatorEnemy1.SetBool("enemyAttack", false);
        }

        else if (enemy2.activeSelf)
        {
            animatorEnemy2.SetBool("jimmyAttack", false);
            animatorEnemy2.SetBool("jimmyStrongerAttack", false);
            animatorEnemy2.SetBool("jimmyEmpathy", false);
            animatorEnemy2.SetBool("jimmyStrongerEmpathy", false);
            animatorEnemy2.SetBool("jimmyItem", false);
            animatorEnemy2.SetBool("vanessaAttack", false);
            animatorEnemy2.SetBool("vanessaStrongerAttack", false);
            animatorEnemy2.SetBool("vanessaEmpathy", false);
            animatorEnemy2.SetBool("vanessaStrongerEmpathy", false);
            animatorEnemy2.SetBool("vanessaItem", false);
            animatorEnemy2.SetBool("enemyAttack", false);
        }

        else if (enemy3.activeSelf)
        {
            animatorEnemy3.SetBool("jimmyAttack", false);
            animatorEnemy3.SetBool("jimmyStrongerAttack", false);
            animatorEnemy3.SetBool("jimmyEmpathy", false);
            animatorEnemy3.SetBool("jimmyStrongerEmpathy", false);
            animatorEnemy3.SetBool("jimmyItem", false);
            animatorEnemy3.SetBool("vanessaAttack", false);
            animatorEnemy3.SetBool("vanessaStrongerAttack", false);
            animatorEnemy3.SetBool("vanessaEmpathy", false);
            animatorEnemy3.SetBool("vanessaStrongerEmpathy", false);
            animatorEnemy3.SetBool("vanessaItem", false);
            animatorEnemy3.SetBool("enemyAttack", false);
        }

        else if (enemy4.activeSelf)
        {
            animatorEnemy4.SetBool("jimmyAttack", false);
            animatorEnemy4.SetBool("jimmyStrongerAttack", false);
            animatorEnemy4.SetBool("jimmyEmpathy", false);
            animatorEnemy4.SetBool("jimmyStrongerEmpathy", false);
            animatorEnemy4.SetBool("jimmyItem", false);
            animatorEnemy4.SetBool("vanessaAttack", false);
            animatorEnemy4.SetBool("vanessaStrongerAttack", false);
            animatorEnemy4.SetBool("vanessaEmpathy", false);
            animatorEnemy4.SetBool("vanessaStrongerEmpathy", false);
            animatorEnemy4.SetBool("vanessaItem", false);
            animatorEnemy4.SetBool("enemyAttack", false);
        }

        else if (boss1.activeSelf)
        {
            animatorBoss1.SetBool("jimmyAttack", false);
            animatorBoss1.SetBool("jimmyStrongerAttack", false);
            animatorBoss1.SetBool("jimmyEmpathy", false);
            animatorBoss1.SetBool("jimmyStrongerEmpathy", false);
            animatorBoss1.SetBool("jimmyItem", false);
            animatorBoss1.SetBool("vanessaAttack", false);
            animatorBoss1.SetBool("vanessaStrongerAttack", false);
            animatorBoss1.SetBool("vanessaEmpathy", false);
            animatorBoss1.SetBool("vanessaStrongerEmpathy", false);
            animatorBoss1.SetBool("vanessaItem", false);
            animatorBoss1.SetBool("enemyAttack", false);
        }

        else if (boss2.activeSelf)
        {
            animatorBoss2.SetBool("jimmyAttack", false);
            animatorBoss2.SetBool("jimmyStrongerAttack", false);
            animatorBoss2.SetBool("jimmyEmpathy", false);
            animatorBoss2.SetBool("jimmyStrongerEmpathy", false);
            animatorBoss2.SetBool("jimmyItem", false);
            animatorBoss2.SetBool("vanessaAttack", false);
            animatorBoss2.SetBool("vanessaStrongerAttack", false);
            animatorBoss2.SetBool("vanessaEmpathy", false);
            animatorBoss2.SetBool("vanessaStrongerEmpathy", false);
            animatorBoss2.SetBool("vanessaItem", false);
            animatorBoss2.SetBool("enemyAttack", false);
        }

        else if (boss3.activeSelf)
        {
            animatorBoss3.SetBool("jimmyAttack", false);
            animatorBoss3.SetBool("jimmyStrongerAttack", false);
            animatorBoss3.SetBool("jimmyEmpathy", false);
            animatorBoss3.SetBool("jimmyStrongerEmpathy", false);
            animatorBoss3.SetBool("jimmyItem", false);
            animatorBoss3.SetBool("vanessaAttack", false);
            animatorBoss3.SetBool("vanessaStrongerAttack", false);
            animatorBoss3.SetBool("vanessaEmpathy", false);
            animatorBoss3.SetBool("vanessaStrongerEmpathy", false);
            animatorBoss3.SetBool("vanessaItem", false);
            animatorBoss3.SetBool("enemyAttack", false);
        }
    }


}
