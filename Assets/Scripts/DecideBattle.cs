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
    public GameObject enemiesBattle;
    public GameObject bossesBattle;
    public GameObject player1turn;
    public GameObject player1turnB;
    public GameObject player2turnB;
    public GameObject enemyTurn;
    public GameObject enemyTurnB;
    public GameObject enemyAura;
    public GameObject enemyAuraB;
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
                enemiesBattle.SetActive(true);
                enemy1.SetActive(true);
                break;

            case "dois":
                enemiesBattle.SetActive(true);
                enemy2.SetActive(true);
                break;

            case "tres":
                enemiesBattle.SetActive(true);
                enemy3.SetActive(true);
                
                break;

            case "quatro":
                enemiesBattle.SetActive(true);
                enemy4.SetActive(true);
                player1turn.transform.position = new Vector3(player1turn.transform.position.x - 60, player1turn.transform.position.y, player1turn.transform.position.z);
                enemyTurn.transform.position = new Vector3(enemyTurn.transform.position.x - 200, enemyTurn.transform.position.y, enemyTurn.transform.position.z);
                enemyAura.transform.position = new Vector3(enemyAura.transform.position.x - 200, enemyAura.transform.position.y, enemyAura.transform.position.z);
                break;

            case "boss1":
                bossesBattle.SetActive(true);
                boss1.SetActive(true);
                break;

            case "boss2":
                bossesBattle.SetActive(true);
                boss2.SetActive(true);
                player1turnB.transform.position = new Vector3(player1turnB.transform.position.x, player1turnB.transform.position.y + 200, player1turnB.transform.position.z);
                player2turnB.transform.position = new Vector3(player2turnB.transform.position.x, player2turnB.transform.position.y + 200, player2turnB.transform.position.z);
                enemyTurnB.transform.position = new Vector3(enemyTurnB.transform.position.x - 250, enemyTurnB.transform.position.y, enemyTurnB.transform.position.z);
                enemyAuraB.transform.position = new Vector3(enemyAuraB.transform.position.x - 250, enemyAuraB.transform.position.y, enemyAura.transform.position.z);
                enemyTurnB.transform.Rotate(0f,0f,90f);
                break;

            case "boss3":
                bossesBattle.SetActive(true);
                boss3.SetActive(true);
                player1turnB.transform.position = new Vector3(player1turnB.transform.position.x + 300, player1turnB.transform.position.y, player1turnB.transform.position.z);
                player2turnB.transform.position = new Vector3(player2turnB.transform.position.x + 110, player2turnB.transform.position.y, player2turnB.transform.position.z);
                enemyTurnB.transform.position = new Vector3(enemyTurnB.transform.position.x + 210, enemyTurnB.transform.position.y, enemyTurnB.transform.position.z);
                enemyAuraB.transform.position = new Vector3(enemyAuraB.transform.position.x + 210, enemyAuraB.transform.position.y, enemyAura.transform.position.z);
                break;
        }
    
    }
}
