using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecideBattle : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy1BG;
    public GameObject enemy2;
    public GameObject enemy2BG;
    public GameObject enemy3;
    public GameObject enemy3BG;
    public GameObject enemy4;
    public GameObject enemy4BG;
    public GameObject boss1;
    public GameObject boss1BG;
    public GameObject boss2;
    public GameObject boss2BG;
    public GameObject boss3;
    public GameObject boss3BG;
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
                enemy1BG.SetActive(true);
                break;

            case "dois":
                enemy2.SetActive(true);
                enemy2BG.SetActive(true);
                break;

            case "tres":
                enemy3.SetActive(true);
                enemy3BG.SetActive(true);
                break;

            case "quatro":
                enemy4.SetActive(true);
                enemy4BG.SetActive(true);
                break;

            case "boss1":
                boss1.SetActive(true);
                boss1BG.SetActive(true);
                break;

            case "boss2":
                boss2.SetActive(true);
                boss2BG.SetActive(true);
                break;

            case "boss3":
                boss3.SetActive(true);
                boss3BG.SetActive(true);
                break;
        }
    
    }
}
