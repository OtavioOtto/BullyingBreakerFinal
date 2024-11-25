using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecideBattle : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject boss1;
    public GameObject boss2;
    public GameObject boss3;
    public RecruitedEnemiesHadler enemies;
    private string battle;

    private void Start()
    {
        battle = enemies.lastBattle;
        BattleDecider();
    }
    private void BattleDecider() {

        switch (battle) {

            case "um":
                enemy1.SetActive(true);
                break;

            case "dois":
                enemy2.SetActive(true);
                break;

            case "tres":
                enemy3.SetActive(true);
                break;

            case "quatro":
                enemy4.SetActive(true);
                break;

            case "boss1":
                boss1.SetActive(true);
                break;

            case "boss2":
                boss2.SetActive(true);
                break;

            case "boss3":
                boss3.SetActive(true);
                break;
        }
    
    }
}
